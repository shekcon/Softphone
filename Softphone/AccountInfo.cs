using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softphone
{
    public enum ListCodeType
    {
        Error = 0,
        Valid = 403
    }
    public class AccountInfo
    {
        private int maxiTimeError_ { get; set; }
        public int validTime_ { get; set; }

        public bool allowRegister_ = true;
        public ListCodeType CodeType_ { get; set; }
        public int StatusCode_ { get; set; }
        public AccountInfo()
        {
            validTime_ = 0;
            maxiTimeError_ = 3;
        }
        public AccountInfo(int maxiTime)
        {
            maxiTimeError_ = maxiTime;
        }
        public bool Checking()
        {
            if (!allowRegister_) return false;
            switch (StatusCode_)
            {
                case 0:
                    {
                        validTime_++;
                        CodeType_ = ListCodeType.Error;
                        if (validTime_ >= maxiTimeError_)
                        {
                            CodeType_ = ListCodeType.Error;
                            allowRegister_ = false;
                            return false;
                        }
                    }
                    break;
                case 403:
                    {
                        validTime_++;
                        if (validTime_>= maxiTimeError_)
                        {
                            CodeType_ = ListCodeType.Valid;
                            allowRegister_ = false;
                            return false;
                        }
                    }
                    break;
            }
            return true;
        }
        public void RefeshRegister()
        {
            validTime_ = 0;
            allowRegister_ = true;
        }
        public string StatusInfor()
        {
            switch (CodeType_)
            {
                case ListCodeType.Error: {
                        return "Sever not found";
                    }

                case ListCodeType.Valid:
                    {
                        return "Wrong password or Username";
                    }
            }
            return "Registering";
        }
    }
}
