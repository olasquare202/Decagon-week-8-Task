//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using System.IO;
//using Hotel_Rental.Interface;

//namespace Hotel.Core.Helpers
//{
//    public class ReadFromJsonFile : IReadWriteToJson
//    {
//        public static string path = @"C:\Users\hp\source\repos\Hotel_Rental\Hotel.Infrastructure\db\";
//       /* public ReadFromJsonFile()
//        {
//            UpdatePath();
//        }*/
//        public async Task<bool> WriteJsonAsync<T>(T jsonFileType, string jsonName)
//        {
//            try
//            {
//               // UpdatePath();
//                string JsonPath = path + jsonName;
//                string json = JsonConvert.SerializeObject(jsonFileType) + Environment.NewLine;
//                await File.AppendAllTextAsync(JsonPath, json);
//                return true;
//            }
//            catch
//            {
//                throw new Exception("Unexception error occured");
//            }
//        }
//        public async Task<List<T>> ReadJsonAsync<T>(string jsonName)
//        {
//            try
//            {
//               // UpdatePath();
//                string JsonPath = path + jsonName;
//                var serializer = new JsonSerializer();
//                string readText = await File.ReadAllTextAsync(JsonPath);
//                var objects = new List<T>();
//                using (var stringReader = new StringReader(readText))
//                using (var jsonReader = new JsonTextReader(stringReader))
//                {
//                    jsonReader.SupportMultipleContent = true;
//                    while (jsonReader.Read())
//                    {
//                        T customer = serializer.Deserialize<T>(jsonReader);
//                        objects.Add(customer);
//                    }
//                }
//                return objects;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//        public async Task<bool> UpdateJsonAsync<T>(List<T> models, string fileName)
//        {
//            try
//            {
//                //UpdatePath();
//                string json = "";
//                string jasonPath = path + fileName;
//                foreach (T model in models)
//                {
//                    json += JsonConvert.SerializeObject(model) + Environment.NewLine;
//                }
//                await File.WriteAllTextAsync(jasonPath, json);
//                return true;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//       /* public static void UpdatePath()
//        {
//            string[] pathArr = path.Split(@"\");
//            path = "";
//            for (int i = 0; i < pathArr.Length - 1; i++)
//            {
//                if (pathArr[i] == "Hotel_Rental")
//                {
//                    path += pathArr[i] + @"\";
//                    break;
//                }
//                path += pathArr[i] + @"\HotelSiteInfrastructure\db\";
//            }
//        }*/
//    }
//}