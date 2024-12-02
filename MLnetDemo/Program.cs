using MLnetDemo;
Console.WriteLine("Write a comment: ");
var sampleInput = Console.ReadLine();
var input = new SentimentModel.ModelInput()
{
    Col0 = sampleInput
};
if (sampleInput == null)
{
    Console.WriteLine("please write something");
}
else
   
{
    var result = SentimentModel.Predict(input);

    var sentiment = result.PredictedLabel == 1 ? "positive comment" : "negative comment";
    var maxConfidence = result.Score.Max();
    Console.WriteLine($"Text: {input.Col0}\nGuess: {sentiment}");
    Console.WriteLine($"Confidence: %{maxConfidence*100:F2}");
    
}


