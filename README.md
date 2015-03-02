# GeoUtils
A C# class for handling basic geographical calculations.
<br><br>
This class currently supports the calculation of distance between two Latitude and Longitude coordinates, as well as the calculation of an offset from a point, with direction and distance from that point.
<br><br>
## Calculating an offset ##
        GeoUtils.GeoUtils.CalculateOffset(*double latitude, double longitude, double offsetDistance, double heading*);
Returns a GeoCoordinate object, which contains a Latitude property (double) and a Longitude property (double).
<br><br>
## Calculating distance between points ##
         GeoUtils.GeoUtils.CalculateDistanceBetween(*double latitude1, double longitude1, double latitude2, double longitude2*);
Returns a double with the distance in metres.
<br><br>
## License ##
The MIT License (MIT)

Copyright (c) 2015, Cameron Carmichael Alonso

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
