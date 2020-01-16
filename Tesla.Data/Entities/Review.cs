using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.Data.Entities
{
    public class Review
    {
        public Guid Id { get; set; }
        public string SentimentText { get; set; }
        public bool Sentiment { get; set; }
    }
}
