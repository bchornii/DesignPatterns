﻿namespace _01_Composite
{
    interface IDocumentComponent
    {
        string GatherData();
        void AddComponent(IDocumentComponent documentComponent);
    }
}
