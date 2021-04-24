using System;
using Microsoft.AspNetCore.Components;

namespace ExperimentWithControlsBlazor.Pages
{
    public partial class Index
    {
        private string DisplayValue = "";

        private void UpdateValue(ChangeEventArgs e)
        {
            DisplayValue = e.Value.ToString();
        }

        private void UpdateNumericValue(ChangeEventArgs e)
        {
            if (int.TryParse(e.Value.ToString(), out int result))
            {
                DisplayValue = e.Value.ToString();
            }
        }

        private void ButtonClick(string displayValue)
        {
            DisplayValue = displayValue;
        }
    }
}
