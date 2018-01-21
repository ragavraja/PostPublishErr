using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProIndian.Model;

namespace ProIndian.ViewModel
{
    public class MainViewModel
    {

        public MainViewModel()
        {
            Ministries = new ObservableCollection<Ministry>
            {
                          new Ministry { MinistryName="Ministry of Agriculture & Farmer Welfare" ,MinistryWebsite=" http://agriculture.gov.in/" },
                 new Ministry { MinistryName = "Ministry of AYUSH" ,MinistryWebsite="http://ayush.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Chemicals and Fertilizers" ,MinistryWebsite="http://chemicals.nic.in/" },
                 new Ministry { MinistryName = "Ministry of Civil Aviation" ,MinistryWebsite="http://civilaviation.gov.in/" },
                 new Ministry { MinistryName = "Ministry of Coal" ,MinistryWebsite="http://coal.nic.in/" },
                 new Ministry { MinistryName = "Ministry of Commerce and Industry" ,MinistryWebsite="http://www.commerce.gov.in/" },
                 new Ministry { MinistryName = "Ministry of Communications" ,MinistryWebsite="http://dot.gov.in/" },
                 new Ministry { MinistryName = "Ministry of Consumer Affairs, Food and Public Distribution" ,MinistryWebsite="http://www.fcamin.nic.in/" },
                 new Ministry { MinistryName = "Ministry of Corporate Affairs" ,MinistryWebsite="http://www.mca.gov.in/" },
                 new Ministry { MinistryName = "Ministry of Culture" ,MinistryWebsite="http://indiaculture.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Defence" ,MinistryWebsite="https://www.mod.gov.in/ " },
                 new Ministry { MinistryName = "Ministry for Development of North Eastern Region" ,MinistryWebsite="http://mdoner.gov.in " },
                 new Ministry { MinistryName = "Ministry of Drinking Water and Sanitation" ,MinistryWebsite="http://mdws.gov.in/" },
                 new Ministry { MinistryName = "Ministry of Earth Sciences" ,MinistryWebsite="http://www.moes.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Electronics and Information Technology" ,MinistryWebsite="http://meity.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Environment, Forests and Climate Change" ,MinistryWebsite="http://www.envfor.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of External Affairs" ,MinistryWebsite="http://mea.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Finance" ,MinistryWebsite="http://finmin.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Food Processing Industries" ,MinistryWebsite="http://www.mofpi.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Health and Family Welfare" ,MinistryWebsite="http://www.mohfw.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Heavy Industries and Public Enterprises" ,MinistryWebsite="http://dpe.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Home Affairs" ,MinistryWebsite="http://mha.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Housing and Urban Poverty Alleviation" ,MinistryWebsite=" http://mhupa.gov.in/" },
                 new Ministry { MinistryName = "Ministry of Human Resource Development" ,MinistryWebsite="http://mhrd.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Information and Broadcasting" ,MinistryWebsite="http://mib.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Labour and Employment" ,MinistryWebsite="http://labour.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Law and Justice" ,MinistryWebsite="http://www.lawmin.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Micro, Small and Medium Enterprises" ,MinistryWebsite="http://www.msme.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Mines" ,MinistryWebsite="https://mines.gov.in/Home/Index " },
                 new Ministry { MinistryName = "Ministry of Minority Affairs" ,MinistryWebsite="http://minorityaffairs.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of New and Renewable Energy" ,MinistryWebsite="http://www.mnre.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Panchayati Raj" ,MinistryWebsite="http://www.panchayat.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Parliamentary Affairs" ,MinistryWebsite="http://mpa.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Personnel, Public Grievances and Pensions" ,MinistryWebsite=" http://www.persmin.nic.in/" },
                 new Ministry { MinistryName = "Ministry of Petroleum and Natural Gas" ,MinistryWebsite="http://petroleum.nic.in/x " },
                 new Ministry { MinistryName = "Ministry of Planning" ,MinistryWebsite="http://www.planningcommission.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Power" ,MinistryWebsite="http://www.powermin.nic.in/    " },
                 new Ministry { MinistryName = "Ministry of Railways" ,MinistryWebsite="http://indianrailways.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Road Transport and Highways" ,MinistryWebsite="http://morth.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Rural Development" ,MinistryWebsite="http://www.rural.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Science and Technology" ,MinistryWebsite="http://www.dst.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Shipping" ,MinistryWebsite="http://shipping.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Social Justice and Empowerment" ,MinistryWebsite="http://www.socialjustice.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Statistics and Programme Implementation" ,MinistryWebsite="http://www.mospi.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Skill Development and Entrepreneurship" ,MinistryWebsite="http://www.skilldevelopment.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Steel" ,MinistryWebsite="http://steel.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Textiles" ,MinistryWebsite="http://www.texmin.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Tourism" ,MinistryWebsite="http://www.tourism.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Tribal Affairs" ,MinistryWebsite="http://tribal.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Urban Development" ,MinistryWebsite="http://www.moud.gov.in/ " },
                 new Ministry { MinistryName = "Ministry of Water Resources, River Development and Ganga Rejuvenation" ,MinistryWebsite="http://wrmin.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Women and Child Development" ,MinistryWebsite="http://wcd.nic.in/ " },
                 new Ministry { MinistryName = "Ministry of Youth Affairs and Sports" ,MinistryWebsite="https://www.yas.nic.in/ " }


            };
        }
        public ObservableCollection<Ministry> Ministries { get; private set; }


    }
}
