using Blazor.AspectRatioCalculator.Models;
using Blazor.AspectRatioCalculator.Utilities;
using Microsoft.AspNetCore.Components;

namespace Blazor.AspectRatioCalculator.Pages
{
    public partial class Index
    {
        private Ratio? _selectedRatio;
        private int _w1;
        private int _w2;
        private int _h1;
        private int _h2;

        override protected void OnInitialized()
        {
            ResetForm();
        }

        private void OnRatioSelected(int id)
        {
            _selectedRatio = CommonUtility.CommonRatios.FirstOrDefault(r => r.Id == id);
            ChangeSelectedAspectRatio();
        }

        private void ResetForm()
        {
            _selectedRatio = CommonUtility.CommonRatios.FirstOrDefault(r => r.Selected);
            ChangeSelectedAspectRatio();
        }

        private void ChangeSelectedAspectRatio()
        {
            if (_selectedRatio != null)
            {
                _w1 = _selectedRatio.Width;
                _h1 = _selectedRatio.Height;
                _w2 = CalculateAspectRatio(_h1);
                _h2 = CalculateAspectRatio(_w1);
                StateHasChanged();
            }
        }

        private void OnWidth1Changed(int w)
        {
            _w1 = w;
            _w2 = CalculateAspectRatio(_h2);
        }

        private void OnHeigh1Changed(int h)
        {
            _h1 = h;
            _h2 = CalculateAspectRatio(_w2);
        }

        private void OnWidthChanged(int w)
        {
            _w2 = w;
            _h2 = CalculateAspectRatio(_w2);
        }

        private void OnHeighChanged(int h)
        {
            _h2 = h;
            _w2 = CalculateAspectRatio(_h2);
        }

        private int CalculateAspectRatio(int givenValue)
        {
            var aspectRatio = (double)_h1 / _w1;
            return (int)(givenValue * aspectRatio);
        }
    }
}
