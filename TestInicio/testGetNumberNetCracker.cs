using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TT.Dto;
using TT.Proxy;

namespace TestInicio
{
    public partial class testGetNumberNetCracker : Form
    {
        public testGetNumberNetCracker()
        {
            InitializeComponent();
        }

        private void testGetNumberNetCracker_Load(object sender, EventArgs e)
        {
            this.txbCrm_in_use.Text = "TCRM";
            this.txbRequest_id.Text = "Example_PMO_Reser_001";
            this.txbArea_code.Text = "1";
            this.txbCountry_code.Text = "57";
            this.txbCity_code.Text = "11001";
            this.txbConsecutive_number.Text = "false";
            this.txbQuantity_numbers.Text = "20";
            this.txbTransaction.Text = "ao_gt38";
            this.txbInitial_numbe.Text = "0000000";
            this.txbFinal_number.Text = "9999999";
            this.txbCategory.Text = "NORMAL";
            this.txbStatus.Text = "Available";
        }

        private void btnGetNumber_Click(object sender, EventArgs e)
        {
            numberProxy _numberProxy = new numberProxy();
            getNumberRequestDto _getNumberRequestDto = new getNumberRequestDto();
            _getNumberRequestDto.crm_in_use = this.txbCrm_in_use.Text;
            _getNumberRequestDto.request_id= this.txbRequest_id.Text;
            _getNumberRequestDto.area_code=   this.txbArea_code.Text;
            _getNumberRequestDto.country_code=   this.txbCountry_code.Text;
            _getNumberRequestDto.city_code=  this.txbCity_code.Text;
            _getNumberRequestDto.consecutive_number= Convert.ToBoolean(this.txbConsecutive_number.Text);
            _getNumberRequestDto.quantity_numbers=  this.txbQuantity_numbers.Text;
            _getNumberRequestDto.transaction_id= this.txbTransaction.Text;
            _getNumberRequestDto.initial_number= this.txbInitial_numbe.Text;
            _getNumberRequestDto.final_number= this.txbFinal_number.Text;
            _getNumberRequestDto.category= this.txbCategory.Text;
            _getNumberRequestDto.status= this.txbStatus.Text;
            getNumberResponseDto _getNumberResponseDto= _numberProxy.get(_getNumberRequestDto);
            this.txbRespuesta.Text = JsonConvert.SerializeObject(_getNumberResponseDto).ToString();
        }
    }
}
