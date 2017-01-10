using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using NLog;

namespace Data.Model
{
    public class Result<T>
    {
        public T Data { get; set; }
        public string Message { get; set; } = null;
        public bool Success { get; set; } = true;
        private static Logger logger;

        public Result(T data)
        {
            logger = LogManager.GetCurrentClassLogger();
            this.Data = data;
        }

        public void ErrorIfDataNull()
        {
            if (Data == null)
            {
                logger.Info("Null data");
                Success = false;
                Message = "Nie znaleziono obiektu";
            }

        }

        public void InsertCheck()
        {
            DMLResult insertResult = (DMLResult)(object)Data;
            if (!insertResult.Success)
            {
                logger.Info("Record isn't inserted");
                Success = false;
                Message = "Bład przy wpisywaniu do bazy";
            }
        }

    }
}

