using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobileInformationManagement.Models;
using MobileInformationManagement.DAL;


namespace MobileInformationManagement.BLL
{
    public class MobileManager
    {
        Mobile mobile = new Mobile();
        MobileGateway mobileGateway = new MobileGateway();

        public string SaveMobile(Mobile mobile)
        {

            bool isExisted = mobileGateway.ExistIMEI(mobile);

            if (isExisted)
            {
                return "Already Exists";
            }

            else
            {
                if (mobile.IMEI.Length == 15)
                {
                    bool isSaved = mobileGateway.SaveMobile(mobile);

                    if (isSaved)
                    {
                        return "Mobile info Saved Successfully";
                    }
                    else
                    {
                        return "Failed to Save";
                    }
                }

                else
                {
                    return "IMEI must be 15 characters long";
                }
            }
        }

        public List<Mobile> GetAllMobile(int lower, int higher)
        {
            return mobileGateway.GetAllMobileFromDB(lower, higher);
        }

        public List<Mobile> GetAllAddedMobile()
        {
            return mobileGateway.GetAllAddedMobileFromDB();
        }

        
        public Mobile GetMobileByIMEI(string imei)
        {
            return mobileGateway.GetMobileByIMEI(imei);
        }


    }
}