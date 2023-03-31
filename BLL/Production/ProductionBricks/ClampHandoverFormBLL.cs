using PhotechxAPI.Models.PlantMaintance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using PhotechxAPI.Models.Production.ProductionBricks;

namespace PhotechxAPI.BLL.Production.ProductionBricks
{
    public class ClampHandoverFormBLL
    {
       
            public static ClampHandoverFormMDL get(string session, int DocEntry)
            {
                try
                {
                    try
                    {
                        var clause = "CHF(" + DocEntry + ")";
                        var data = Pipeline.Get(session, clause);
                        return JsonConvert.DeserializeObject<ClampHandoverFormMDL>(data);
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


            public static List<ClampHandoverFormMDL> get(string session, string Query)
            {
                try
                {
                    try
                    {
                        var Alldata = new List<ClampHandoverFormMDL>();
                        var data = Pipeline.GetMultiple(session, Query);
                        foreach (string infor in data)
                        {
                            Alldata.AddRange(JsonConvert.DeserializeObject<List<ClampHandoverFormMDL>>(infor));
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


            public static string Post(string session, PostClampHandoverFormMDL data)
            {
                try
                {


                    var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                    var Post = Pipeline.Post(session, PostData, "CHF");
                    var Posresult = JsonConvert.DeserializeObject<ClampHandoverFormMDL>(Post);
                    return "Clamp handover form Posted " + Posresult.DocNum;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public static string Patch(string session, PatchClampHandoverFormMDL data, int DocEntry)
            {
                try
                {

                    var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                    var Post = Pipeline.Patch(session, PostData, "CHF(" + DocEntry + ")");
                    return "Clamp handover form has been Updated";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }


        }
 }

