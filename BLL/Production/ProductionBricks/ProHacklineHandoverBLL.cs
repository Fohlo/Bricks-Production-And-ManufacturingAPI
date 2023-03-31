using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using PhotechxAPI.Models.Production.ProductionBricks;

namespace PhotechxAPI.BLL.Production.ProductionBricks
{
    public class ProHacklineHandoverBLL
    {
            public static ProHacklineHandoverMDL get(string session, int DocEntry)
            {
                try
                {
                    try
                    {
                        var clause = "PRODHANDOVER(" + DocEntry + ")";
                        var data = Pipeline.Get(session, clause);
                        return JsonConvert.DeserializeObject<ProHacklineHandoverMDL>(data);
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


            public static List<ProHacklineHandoverMDL> get(string session, string Query)
            {
                try
                {
                    try
                    {
                        var Alldata = new List<ProHacklineHandoverMDL>();
                        var data = Pipeline.GetMultiple(session, Query);
                        foreach (string infor in data)
                        {
                            Alldata.AddRange(JsonConvert.DeserializeObject<List<ProHacklineHandoverMDL>>(infor));
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


            public static string Post(string session, PostProHacklineHandoverMDL data)
            {
                try
                {


                    var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                    var Post = Pipeline.Post(session, PostData, "PRODHANDOVER");
                    var Posresult = JsonConvert.DeserializeObject<ProHacklineHandoverMDL>(Post);
                    return "Production Bricks hackline hand over  has been Posted " + Posresult.DocNum;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public static string Patch(string session, PatchProHacklineHandoverMDL data, int DocEntry)
            {
                try
                {

                    var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                    var Post = Pipeline.Patch(session, PostData, "PRODHANDOVER(" + DocEntry + ")");
                    return "Production Bricks hackline hand over  has been Updated";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }


        }
 }

