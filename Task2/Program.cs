// Source https://github.com/dotnet/csharp-notebooks/blob/main/machine-learning/04-Model%20Evaluation.ipynb
// Import using statements
using System.Text.Json;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.Analysis;
using Microsoft.ML;
using Microsoft.ML.AutoML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using static Microsoft.ML.DataOperationsCatalog;
using static Microsoft.ML.Transforms.OneHotEncodingEstimator;

// Load data
var trainDataPath = @"C:\Users\goblin\Desktop\taxi-fare-train.csv";
DataFrame df = DataFrame.LoadCsv(trainDataPath);

// Initialize MLContext
MLContext mlContext = new MLContext();

// Configure logging
mlContext.Log += (object? sender, LoggingEventArgs e) =>
{
    if (e.Source.Contains("AutoMLExperiment")) Console.WriteLine(e.RawMessage);
};

// Split data into train / test set

// INSERT CODE

// Define training pipeline

// INSERT CODE

// Define experiment
// Use 45 seconds for training time
// Use Root Mean Squared Error as the evaluation metric

// INSERT CODE

// Run experiment

// INSERT CODE

// Print model evaluation metric

// INSERT CODE