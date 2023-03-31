using PhotechxAPI.Models.PlantMaintance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using PhotechxAPI.Models.Production.ProductionBricks;

namespace PhotechxAPI.BLL.Production.ProductionBricks
{
    public class ProductionLogSheetBLL
    {
        
            public static ProductionLogSheetMDL get(string session, int DocEntry)
            {
                try
                {
                    try
                    {
                        var clause = "PRODLOGSHEET(" + DocEntry + ")";
                        var data = Pipeline.Get(session, clause);
                        return JsonConvert.DeserializeObject<ProductionLogSheetMDL>(data);
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


            public static List<ProductionLogSheetMDL> get(string session, string Query)
            {
                try
                {
                    try
                    {
                        var Alldata = new List<ProductionLogSheetMDL>();
                        var data = Pipeline.GetMultiple(session, Query);
                        foreach (string infor in data)
                        {
                            Alldata.AddRange(JsonConvert.DeserializeObject<List<ProductionLogSheetMDL>>(infor));
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


            public static string Post(string session, PostProductionLogSheetMDL data)
            {
                try
                {


                    var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                    var Post = Pipeline.Post(session, PostData, "PRODLOGSHEET");
                    var Posresult = JsonConvert.DeserializeObject<ProductionLogSheetMDL>(Post);
                    return "Production log sheet has been Posted " + Posresult.DocNum;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public static string Patch(string session, PatchProductionLogSheetMDL data, int DocEntry)
            {
                try
                {

                    var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                    var Post = Pipeline.Patch(session, PostData, "PRODLOGSHEET(" + DocEntry + ")");
                    return "Production log sheet has been Updated";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }


        }
    }

