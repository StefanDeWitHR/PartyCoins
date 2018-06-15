using System;

namespace PartyCoinAPI.Models
{
    public  class ErrorViewModel<T>
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        // Check for valid models 
        public bool IsValidModel(T model)
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