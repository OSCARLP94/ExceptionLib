using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExceptionLib
{
    public class ResultDto
    {
        public ResultDto() { }
        public ResultDto(IActionResult result)
        {
            var jsonResult = result as JsonResult;
            var origin = JsonConvert.DeserializeObject<ResultDto>(JsonConvert.SerializeObject(jsonResult.Value));
            this.response = origin.response;
            this.successful = origin.successful;
            this.message = origin.message;
            this.data = origin.data;
            this.error = origin.error;
        }

        public bool response { get; set; }

        public bool successful { get; set; }

        public dynamic data { get; set; }

        public string message { get; set; }

        public string error { get; set; }
    }
}
