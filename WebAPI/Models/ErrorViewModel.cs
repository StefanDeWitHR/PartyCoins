using System;

namespace WebAPI.Models
{
    public  class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        // Check for valid models 
        public bool IsValidMode<T>(T model)
        {
            Logging LogRec = new Logging();

            if (model == null)
            {
                LogRec.Type = "Model validation";
                LogRec.Message = "Model " + model  + "is not valid" ;

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}