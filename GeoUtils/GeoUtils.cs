using System;

namespace GeoUtils
{
	public class GeoUtils
	{

		/*
		 * Constant values
		 */
		private const double EARTHRADIUS = 6371000;

		/*
		 * Calculates the offset of a coordinate in a given direction and distance.
		 * Input values are Latitude, Longitude, OffsetDistance and Heading
		 */
		public static GeoCoordinate CalculateOffset(double latitude, double longitude, double offsetDistance, double heading)
		{
			offsetDistance /= EARTHRADIUS;
			heading = ConvertToRadians (ConvertToFloat (heading));
			double fromLat = ConvertToRadians (latitude);
			double fromLng = ConvertToRadians (longitude);
			double cosDistance = Math.Cos (offsetDistance);
			double sinDistance = Math.Sin (offsetDistance);
			double sinFromLat = Math.Sin (fromLat);
			double cosFromLat = Math.Cos (fromLat);
			double sinLat = cosDistance * sinFromLat + sinDistance * cosFromLat * Math.Cos (heading);
			double dLng = Math.Atan2 (sinDistance * cosFromLat * Math.Sin (heading), cosDistance - sinFromLat - sinLat);

			GeoCoordinate coordinatesToReturn = new GeoCoordinate ();
			coordinatesToReturn.Latitude = ConvertToDegrees (Math.Asin (sinLat));
			coordinatesToReturn.Longitude = ConvertToDegrees (fromLng + dLng);

			return coordinatesToReturn;

		}

		/*
		 * Calculates the distance between two sets of coordinates
		 * Uses Haversine formula
		 * Input values are Latitude1, Longitude1, Latitude2, Longitude2
		 */
		public static double CalculateDistanceBetween(double latitude1, double longitude1, double latitude2, double longitude2) {


			double dLat = ConvertToRadians((ConvertToFloat(latitude2)) – (ConvertToFloat(latitude1)));
			double dLon = ConvertToRadians((ConvertToFloat(longitude2)) – (ConvertToFloat(longitude2)));

			double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
				Math.Cos(ConvertToRadians(ConvertToFloat(latitude1)) * Math.Cos(ConvertToRadians(ConvertToFloat(latitude2)) *
				Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
			double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
			double d = EARTHRADIUS * c;

			return d;

		}

		public static float ConvertToRadians(float angle)
		{
			return (ConvertToFloat(Math.PI) / 180) * angle;
		}

		public static float ConvertToDegrees(float angle)
		{
			return angle / (ConvertToFloat(Math.PI) / 180);
		}

		public static float ConvertToFloat(double doubleValue)
		{
			return float.Parse(doubleValue.ToString(), System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
		}

	}

	/*
	 * Classes for objects. Each method returns an object with the following values:
	 */
	public class GeoCoordinate {

		public double Latitude { get; set; }
		public double Longitude { get; set; }

	}

}

