using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_07.RawData
{
    public class Model
    {
        public Model(string modelType)
        {
            ModelType = modelType;
        }
        public string ModelType { get; set; }
    }
}
