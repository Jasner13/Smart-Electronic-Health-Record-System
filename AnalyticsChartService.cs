using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using OxyPlot.WindowsForms;
using OxyPlot.Annotations;



namespace SEHRS
{
    public static class AnalyticsChartService
    {
        private static readonly string connectionString =@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\OOP2 SecondSem\FinalProject - WinForms\SEHRSFinal\SEHRS\Resources\SEHRSDB\SEHRS(db).accdb""";

        public static Dictionary<string, int> GetPatientPuroksByYear()
        {
            var result = new Dictionary<string, int>();

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT PN.[PurokNumber], MIN(YEAR(PH.[DateAdded])) AS FirstYearAdded
                    FROM [PatientName] PN
                    INNER JOIN [PatientHistory] PH ON PN.PatientID = PH.PatientID
                    WHERE PN.[PurokNumber] IS NOT NULL
                    GROUP BY PN.[PurokNumber]
                    ORDER BY PN.[PurokNumber]";

                using (var cmd = new OleDbCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string purok = reader["PurokNumber"].ToString();
                        int yearAdded = Convert.ToInt32(reader["FirstYearAdded"]);

                        result[purok] = yearAdded;
                    }
                }
            }

            return result.OrderBy(kvp => int.Parse(kvp.Key)).ToDictionary(k => k.Key, v => v.Value);
        }
        public static Dictionary<string, int> GetDiagnosisCounts()
        {
            var result = new Dictionary<string, int>();

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT PH.[MedicalHistory], COUNT(*) AS PatientCount
            FROM [PatientHistory] PH
            GROUP BY PH.[MedicalHistory]
            ORDER BY PatientCount DESC";

                using (var cmd = new OleDbCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string diagnosis = reader["MedicalHistory"].ToString();
                        int patientCount = Convert.ToInt32(reader["PatientCount"]);

                        result[diagnosis] = patientCount;
                    }
                }
            }

            return result;
        }

        public static PlotModel CreateDiagnosisBarChart
            (Dictionary<string, int> diagnosisData, string title)
        {
            var model = new PlotModel
            {
                Title = title,
                TitleFontSize = 16,
                DefaultFont = "Segoe UI",
                PlotMargins = new OxyThickness(60, 40, 40, 40)
            };

            // Category axis (Y-axis - Diagnoses)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Diagnosis",
                IsTickCentered = true,
                GapWidth = 0.3
            };

            int maxValue = diagnosisData.Any() ? diagnosisData.Max(x => x.Value) : 0;

           
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Patient Count",
                Minimum = 0,
                Maximum = maxValue * 1.2,
                MajorStep = Math.Max(1, maxValue / 5),
                MinorStep = 1,
                AbsoluteMinimum = 0,
                IsAxisVisible = true
            };

          
            var series = new BarSeries
            {
                FillColor = OxyColor.FromRgb(70, 130, 180),
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "",
                BarWidth = 0.5
            };

          
            int counter = 0;
            foreach (var item in diagnosisData)
            {
                int count = item.Value;
                string diagnosis = item.Key;

                series.Items.Add(new BarItem { Value = count });
                categoryAxis.Labels.Add(diagnosis);

              
                var annotation = new TextAnnotation
                {
                    Text = count.ToString(),
                    TextPosition = new DataPoint(count + 0.1, counter), 
                    FontSize = 10,
                    TextColor = OxyColors.Black,
                    TextHorizontalAlignment = OxyPlot.HorizontalAlignment.Left,
                    TextVerticalAlignment = OxyPlot.VerticalAlignment.Middle
                };

           
                model.Annotations.Add(annotation);

                counter++;
            }

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);
            model.Series.Add(series);

            model.Legends.Add(new Legend
            {
                LegendPosition = LegendPosition.TopRight,
                LegendPlacement = LegendPlacement.Inside
            });

            return model;
        }
        public static Dictionary<string, int> GetConditionPuroksByYear
            (string condition, DateTime startDate, DateTime endDate)
        {
            var result = new Dictionary<string, int>();

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT PN.[PurokNumber], MIN(YEAR(PH.[DateAdded])) AS FirstYearAdded
                    FROM [PatientName] PN
                    INNER JOIN [PatientHistory] PH ON PN.PatientID = PH.PatientID
                    WHERE PH.[MedicalHistory] LIKE @condition
                    AND PH.[DateAdded] BETWEEN @startDate AND @endDate
                    AND PN.[PurokNumber] IS NOT NULL
                    GROUP BY PN.[PurokNumber]
                    ORDER BY PN.[PurokNumber]";

                using (var cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@condition", $"%{condition}%");
                    cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                    cmd.Parameters.AddWithValue("@endDate", endDate.Date);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string purok = reader["PurokNumber"].ToString();
                            int yearAdded = Convert.ToInt32(reader["FirstYearAdded"]);

                            result[purok] = yearAdded;
                        }
                    }
                }
            }

            return result.OrderBy(kvp => int.Parse(kvp.Key)).ToDictionary(k => k.Key, v => v.Value);
        }

        public static Dictionary<string, Tuple<int, List<int>>> GetPatientCountsAndYearByPurok()
        {
            var result = new Dictionary<string, Tuple<int, List<int>>>();

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT PN.[PurokNumber], COUNT(*) AS PatientCount, YEAR(PH.[DateAdded]) AS YearAdded
            FROM [PatientName] PN
            INNER JOIN [PatientHistory] PH ON PN.PatientID = PH.PatientID
            WHERE PN.[PurokNumber] IS NOT NULL
            GROUP BY PN.[PurokNumber], YEAR(PH.[DateAdded])
            ORDER BY PN.[PurokNumber]";

                using (var cmd = new OleDbCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    // Group the years by PurokNumber
                    var groupedData = new Dictionary<string, List<int>>();

                    while (reader.Read())
                    {
                        string purok = reader["PurokNumber"].ToString();
                        int yearAdded = Convert.ToInt32(reader["YearAdded"]);
                        int count = Convert.ToInt32(reader["PatientCount"]);

                       
                        if (!groupedData.ContainsKey(purok))
                        {
                            groupedData[purok] = new List<int>();
                        }
                        groupedData[purok].Add(yearAdded);
                    }

                   
                    foreach (var entry in groupedData)
                    {
                        result[entry.Key] = new Tuple<int, List<int>>
                            (entry.Value.Count, entry.Value.Distinct().ToList());
                    }
                }
            }

            return result.OrderBy(kvp => int.Parse(kvp.Key))
                        .ToDictionary(k => k.Key, v => v.Value);
        }


        public static PlotModel CreateHorizontalBarChart
            (Dictionary<string, Tuple<int, List<int>>> data, string title)
        {
            var model = new PlotModel
            {
                Title = title,
                TitleFontSize = 16,
                DefaultFont = "Segoe UI",
                PlotMargins = new OxyThickness(40, 20, 40, 60) 
            };

            // Category axis (Y-axis - Purok Numbers)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Purok Number",
                IsTickCentered = true,
                GapWidth = 0.3
            };

            int maxValue = data.Any() ? data.Max(x => x.Value.Item1) : 0;

            // Value axis (X-axis - Patient Count)
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Patient Count",
                Minimum = 0,
                Maximum = maxValue * 1.2,
                MajorStep = Math.Max(1, maxValue / 5),
                MinorStep = 1,
                AbsoluteMinimum = 0,
                IsAxisVisible = true
            };

          
            var series = new BarSeries
            {
                FillColor = OxyColor.FromRgb(70, 130, 180),
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "",
                BarWidth = 0.5
            };

            
            int counter = 0;
            foreach (var item in data)
            {
                int count = item.Value.Item1;
                List<int> years = item.Value.Item2;

                series.Items.Add(new BarItem { Value = count });
                categoryAxis.Labels.Add(item.Key);

                var yearLabel = string.Join(", ", years);

                
               
                var annotation = new TextAnnotation
                {
                    Text = yearLabel,
                    TextPosition = new DataPoint(count + 0.1, counter),
                    FontSize = 10,
                    TextColor = OxyColors.Black,
                    TextHorizontalAlignment = OxyPlot.HorizontalAlignment.Left,
                    TextVerticalAlignment = OxyPlot.VerticalAlignment.Middle
                };
              
                model.Annotations.Add(annotation);

                counter++;
            }

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);
            model.Series.Add(series);

            model.Legends.Add(new Legend
            {
                LegendPosition = LegendPosition.TopRight,
                LegendPlacement = LegendPlacement.Inside
            });

            return model;
        }

    }
}
