﻿using Microsoft.ML.Data;

namespace TransferLearningTF.Clases
{
    public class ImageData
    {
        [LoadColumn(0)]
        public string? ImagePath;

        [LoadColumn(1)]
        public string? Label;
    }
}
