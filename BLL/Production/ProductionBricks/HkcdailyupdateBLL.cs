using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using PhotechxAPI.Models.Production.ProductionBricks;

namespace PhotechxAPI.BLL.Production.ProductionBricks
{
    public class HkcdailyupdateBLL
    {

          public static HkcdailyupdateMDL get(string session, int DocEntry)
            {
                try
                {
                    try
                    {
                        var clause = "HKCDAILYUPDATE(" + DocEntry + ")";
                        var data = Pipeline.Get(session, clause);
                        return JsonConvert.DeserializeObject<HkcdailyupdateMDL>(data);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }


            public static List<HkcdailyupdateMDL> get(string session, string Query)
            {
                try
                {
                    try
                    {
                        var Alldata = new List<HkcdailyupdateMDL>();
                        var data = Pipeline.GetMultiple(session, Query);
                        foreach (string infor in data)
                        {
                            Alldata.AddRange(JsonConvert.DeserializeObject<List<HkcdailyupdateMDL>>(infor));
                        }
                        return Alldata;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }


            public static string Post(string session, PostHkcdailyupdateMDL data)
            {
                try
                {


                    var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                    var Post = Pipeline.Post(session, PostData, "HKCDAILYUPDATE");
                    var Posresult = JsonConvert.DeserializeObject<HkcdailyupdateMDL>(Post);
                    return "Production Hackline Daily Update has been Posted " + Posresult.DocNum;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public static string Patch(string session, PatchHkcdailyupdateMDL data, int DocEntry)
            {
                try
                {

                    var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                    var Post = Pipeline.Patch(session, PostData, "HKCDAILYUPDATE(" + DocEntry + ")");
                    return "Production Hackline Daily Update has been Updated";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }


        }
}

