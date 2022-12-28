# Purpose

To evaluate the speed of data grids rendering grouped data.  I use the exact same data
consisting of 500 rows of weatherforecasts, and then create a grouped grid for each
Blazor component suite I can find.

I have used `N/A` for the `Group` column where the library automatically collapses
after grouping, as this would be an unfair metric considering the other
libraries expand by default and therefore have more work to do.

## Note
I have sinus problems, so there will be coughing and snorting in the videos.

## Results
|Library|Initial display|Group|Expand/Collapse|Video|
|-------|----------------------|----------------|---------------|-----|
|Blazor-Telerik|7 seconds |11 seconds|6 seconds|[Telerik](https://youtu.be/MHsX0sODAiQ)|
|Blazor-Syncfusion|6 seconds|9 seconds|3 seconds|[Syncfusion](https://youtu.be/mckz26_Npf4)|
|Blazor-DevExpress|6 seconds|N/A|7 seconds|[DevExpress](https://www.youtube.com/watch?v=IxM9kCKyHyQ)|
|Blazor-Radzen|11 seconds|10 seconds|2 seconds|[Radzen](https://youtu.be/6KAeRU4BS18)|
|Blazor-MudBlazor|3 seconds|N/A|1.5 seconds|[MudBlazor](https://youtu.be/UrRAmYbczw40)|
|Blazor-FlexOne|8 seconds|2 seconds|1 second|[FlexOne](https://youtu.be/q6rB51P6A8A)|
|Angular-Telerik|TO DO | TO DO | TO DO| TO DO|