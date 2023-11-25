using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinhHackServer.Models;
using System.Text.Json;

namespace RinhHackServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> GetScore(string jsonFormModel)
        {
            var form = JsonSerializer.Deserialize<FormModel>(jsonFormModel);
            var sampleData = new ScorePredictor.ModelInput()
            {
                Month = form.Month,
                Occupation = form.Occupation,
                Payment_behaviour = form.PaymentBehaviour,
                Age = form.Age,
                Amount_invested_monthly = form.AmountInvestedMonthly,
                Annual_income = form.AnnualIncome,
                Credit_history_age = form.CreditHistoryAge,
                Monthly_balance = form.MonthlyBalance,
                Monthly_inhand_salary = form.MonthlyInhandSalary,
                Num_bank_accounts = form.NumBankAccounts,
                Num_credit_card = form.NumCreditCard,
                Num_credit_inquiries = form.NumCreditInquiries,
                Num_of_loan = form.NumOfLoan,
            };
            return Ok(ScorePredictor.Predict(sampleData).PredictedLabel);
        }
    }
}
