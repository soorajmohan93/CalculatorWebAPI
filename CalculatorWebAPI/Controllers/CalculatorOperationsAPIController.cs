using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CalculatorApplicationLibrary;
using Microsoft.AspNetCore.Http.Features;

namespace CalculatorWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    /*This the API Controller Class with Add, Subtract, Multiply and 
        Divide methods which will call calulator library class methods*/
    public class CalculatorOperationsAPIController : ControllerBase
    {
        private readonly Calculator _calculator;

        public CalculatorOperationsAPIController()
        {
            _calculator = new Calculator();
        }

        //Calling Library class method to add and returns the results
        [HttpGet]
        public double Add(double first, double second)
        {
            return _calculator.Add(first, second);
        }

        //Calling Library class method to subtract and returns the results
        [HttpGet]
        public double Subtract(double first, double second)
        {
            return _calculator.Subtract(first, second);
        }

        //Calling Library class method to multiply and returns the results
        [HttpGet]
        public double Multiply(double first, double second)
        {
            return _calculator.Multiply(first, second);
        }

        //Calling Library class method to divide and returns the results
        [HttpGet]
        public double? Divide(double first, double second)
        {
            try
            {
                return _calculator.Divide(first, second);
            }
            //Divide by Zero Exception is handled by making status code 400 and with error message
            catch (DivideByZeroException ex)
            {
                Response.StatusCode = 400; //Bad Request Error
                //Displaying Error message (Error text can be seen in swaggerUI)
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Divide By Zero not Possible!! Error: " + ex;
                return null;
            }
        }
    }
}