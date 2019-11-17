using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;





//// create user x
////<RegisterBindingModel xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/apiWithAuthenication.Models">
////  <ConfirmPassword>Pwd12345.</ConfirmPassword>
////  <Email>dywork1 @gmail.com</Email>
////  <Password>Pwd12345.</Password>
////</RegisterBindingModel>



//    // get token
//    {
//    "access_token": "OFJB0Q5tAoP6PlhiuFDnxHvT8qya67ftPOw8NNzCmyiUYwwgHkA4Cvj5vbptl_OkWOnAKkDNehykfjtsMXYiCGok_VUcQ9Iol4-qPKZc6jmnCs6-adRWQBwZUDnz-hc3Xbk0aroaQgWF-9Fmayh-c2UJnDikDWRyxKtY1rqIry2-jPmRkpt6D5LOxCsK2BroHVMsnIsfUYeFx22uWiDptJKzrWMFlLbcTqDp8nY-6tURFNRwM0PW7fnui9tRxNSR_7Xo2Bf_vTG2EFhXSiZm7GFa725EUB_cNAjyoTNwdgF-BzopOPN1BSmpZuWdsagkUGmRAZ2oxi0_OCyE8cvs7Wid51pRJvPWwyhDI6CIPSK9M8L-dWvv51Ds6mX_16_dULb0LtkJS1plXWILzXpaOHlWAx0K0zjjIwldfq3YDf7A6gMVJa6uO_uVJnm9bksri581Aqcbw5pqPex2ZXh858hcJkSdHw9IQiGhS4Mb_T13eNNVjZ9EiRtqC2o3GGzH",
//    "token_type": "bearer",
//    "expires_in": 1209599,
//    "userName": "dywork1@gmail.com",
//    ".issued": "Sun, 17 Nov 2019 21:57:46 GMT",
//    ".expires": "Sun, 01 Dec 2019 21:57:46 GMT"
//}


////get var returned
//use token
//    /// <summary>
//    /// /previous example below
//    /// 

////NEW ONE
//////https://localhost:44370/Help


//https://localhost:44370/api/Account/Register

//<RegisterBindingModel xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/DYdataManager.Models">
//  <ConfirmPassword>Pwd12345.</ConfirmPassword>
//  <Email>dywork1 @gmail.com</Email>
//  <Password>Pwd12345.</Password>
//</RegisterBindingModel>



//Get the token

//https://localhost:44370/token

//body:  
//x-www-form-urlencode

//grant_type  password
//username    dywork1 @gmail.com
//password    Pwd12345.


//{
//    "access_token": "FwHSDVcgAPb7aybM9TE9pz1z-cAL0Ve4Lad46I0i1Oy4WvM_5Go8DQc8jIAug5XmNKrylsNsiL6EvsRXG-WLYd2CfIx1dlK3XZO76-63FlFrav04p6SPCYCUvlZTq3iLmaVzJflmkbktWBFnzNSm5_kTeenslDf6qNtRFfCyLqSbtJUGqbsScukfBI_a6OMjsddZ-1PSi20xTNKBVGM73l8nlWe8SJSIY5wIAYhZp5R04AXr3iXYaVqNfLn7unmGhP9mnX9hU869_SQ5b2q38Ept9kTaH3np5CKd-7L_4FP38mTWfqbTcQLvBd8SdYSmE4AdzjmiihY5uhCNPLFg0Lm8jZYGcfSfnTs98q8I9FtdXiZUfv5r8aYkaJRf1rocd_NYLR1QwFHLfzwLwWsWQIsk2drIXUq2VpfL3zgZpiWtpJ8wGPnqE9OyoOkyP0yqxzy4N4bxyGmlgglUcH29dBe8Jb3Zw4w_nQxRBU1cvbR78qJKO0B99Secm0tWQBP8",
//    "token_type": "bearer",
//    "expires_in": 1209599,
//    "userName": "dywork1@gmail.com",
//    ".issued": "Sun, 17 Nov 2019 21:02:26 GMT",
//    ".expires": "Sun, 01 Dec 2019 21:02:26 GMT"
//}



//----------------------------------
//----------------------------------

//FwHSDVcgAPb7aybM9TE9pz1z-cAL0Ve4Lad46I0i1Oy4WvM_5Go8DQc8jIAug5XmNKrylsNsiL6EvsRXG-WLYd2CfIx1dlK3XZO76-63FlFrav04p6SPCYCUvlZTq3iLmaVzJflmkbktWBFnzNSm5_kTeenslDf6qNtRFfCyLqSbtJUGqbsScukfBI_a6OMjsddZ-1PSi20xTNKBVGM73l8nlWe8SJSIY5wIAYhZp5R04AXr3iXYaVqNfLn7unmGhP9mnX9hU869_SQ5b2q38Ept9kTaH3np5CKd-7L_4FP38mTWfqbTcQLvBd8SdYSmE4AdzjmiihY5uhCNPLFg0Lm8jZYGcfSfnTs98q8I9FtdXiZUfv5r8aYkaJRf1rocd_NYLR1QwFHLfzwLwWsWQIsk2drIXUq2VpfL3zgZpiWtpJ8wGPnqE9OyoOkyP0yqxzy4N4bxyGmlgglUcH29dBe8Jb3Zw4w_nQxRBU1cvbR78qJKO0B99Secm0tWQBP8


//https://localhost:44370/api/values

//headers
//key authorization
//value
//Bearer FwHSDVcgAPb7aybM9TE9pz1z-cAL0Ve4Lad46I0i1Oy4WvM_5Go8DQc8jIAug5XmNKrylsNsiL6EvsRXG-WLYd2CfIx1dlK3XZO76-63FlFrav04p6SPCYCUvlZTq3iLmaVzJflmkbktWBFnzNSm5_kTeenslDf6qNtRFfCyLqSbtJUGqbsScukfBI_a6OMjsddZ-1PSi20xTNKBVGM73l8nlWe8SJSIY5wIAYhZp5R04AXr3iXYaVqNfLn7unmGhP9mnX9hU869_SQ5b2q38Ept9kTaH3np5CKd-7L_4FP38mTWfqbTcQLvBd8SdYSmE4AdzjmiihY5uhCNPLFg0Lm8jZYGcfSfnTs98q8I9FtdXiZUfv5r8aYkaJRf1rocd_NYLR1QwFHLfzwLwWsWQIsk2drIXUq2VpfL3zgZpiWtpJ8wGPnqE9OyoOkyP0yqxzy4N4bxyGmlgglUcH29dBe8Jb3Zw4w_nQxRBU1cvbR78qJKO0B99Secm0tWQBP8



/// </summary>



namespace apiWithAuthenication.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {

            var _userID = RequestContext.Principal.Identity.GetUserId();

            return new string[] { "value1", "value2", _userID };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
