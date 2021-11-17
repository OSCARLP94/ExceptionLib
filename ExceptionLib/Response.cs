using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace ExceptionLib
{
    /// <summary>
    /// Class with methods for manage results and responses like JsonResult
    /// </summary>
    public static class Response
    {
        /// <summary>
        /// Returns JsonResult with successful state
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static JsonResult Successful(dynamic data)
        {
            return new JsonResult(new
            {
                response = true,
                successful = true,
                data = data,
                message = "",
                error = ""
            });
        }

        /// <summary>
        /// Returns JsonResult with successful state and message
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static JsonResult Successful(dynamic data, string message)
        {
            return new JsonResult(new
            {
                response = true,
                successful = true,
                data = data,
                message = message,
                error = ""
            });
        }

        /// <summary>
        /// Returns JsonResult with unsuccessful state
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static JsonResult UnSuccesful(dynamic data)
        {
            return new JsonResult(new
            {
                response = true,
                successful = false,
                data = data,
                message = "",
                error = ""
            });
        }

        /// <summary>
        /// Returns JsonResult with unsuccessful state and message
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static JsonResult UnSuccesful(dynamic data, string message)
        {
            return new JsonResult(new
            {
                response = true,
                successful = false,
                data = data,
                message = message,
                error = ""
            });
        }

        /// <summary>
        /// Returns JsonResult with errors
        /// </summary>
        /// <param name="data"></param>
        /// <param name="errors"></param>
        /// <returns></returns>
        public static JsonResult WithError(string errors)
        {
            return new JsonResult(new
            {
                response = true,
                successful = false,
                data = null as object,
                message = "",
                error = errors
            });
        }

        /// <summary>
        /// Returns JsonResult with exception and message
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static JsonResult WithErrorException(Exception ex, string message)
        {
            return new JsonResult(new
            {
                response = false,
                successful = false,
                data = null as object,
                message = message,
                error = JsonConvert.SerializeObject(ex)
            });
        }

        /// <summary>
        /// Returns JsonResult with exception
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static JsonResult WithErrorException(Exception ex)
        {
            return new JsonResult(new
            {
                response = false,
                successful = false,
                data = null as object,
                message = "",
                error = JsonConvert.SerializeObject(ex)
            });
        }
    }
}