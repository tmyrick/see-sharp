// using System;
// namespace NonPrims
// {
//     public enum ShippingMethod
//     {
//         RegularAirMail = 1,
//         RegisteredAirMail = 2,
//         Express = 3
//     }
//
//     class Enum
//     {
//         static void Main(string[] args)
//         {
//             var method = ShippingMethod.Express;
//             Console.WriteLine((int)method);
//
//             var methodId = 3;
//             Console.WriteLine((ShippingMethod)methodId);
//
//             Console.WriteLine(method);
//
//             var methodName = "Express";
//             var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
//         }
//     }
// }
//
