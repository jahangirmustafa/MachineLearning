using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeslaML.Model;

namespace Tesla.Services
{
    public static class Sentiment
    {
        static MLContext context = new MLContext();
        static ITransformer model = context.Model.Load("C:\\Users\\Jahangir\\Source\\Repos\\MachineLearning\\TeslaML.Model\\MLModel.zip", out var model);

        [ThreadStatic]
        static PredictionEngine<ModelInput, ModelOutput> t_eninge;

        public static PredictionEngine<ModelInput, ModelOutput> GetPredictionEngine()
        {
            if (t_eninge != null)
                return t_eninge;

            return t_eninge = context.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);
        }

        public static ModelOutput Predict(string text)
        {
            var predEngine = GetPredictionEngine();

            return predEngine.Predict(new ModelInput { SentimentText = text });
        }
    }
}
