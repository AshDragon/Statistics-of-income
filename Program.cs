using System;

namespace Statistics_of_income
{
    class Program
    {

        /// <summary>
        /// Принимает введённые значения для рассчитывания затратов и прибыли
        /// </summary>
        /// <param name="args"></param>
        static AmountReceived EstimatedAmount()
        {
            var amountReceived = new AmountReceived();

            Console.Write("Введите сумму вашей месячной зарплаты : ");
            amountReceived.Monthly_salary_amount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сумму оплаты квартиры или дома : ");
            amountReceived.The_amount_of_payment_for_an_apartment_or_house = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сумму оплаты за еду : ");
            amountReceived.Payment_amount_for_food = Convert.ToInt32(Console.ReadLine());

            return amountReceived;
        }

        /// <summary>
        /// Выводит расчётный лист за месяц
        /// </summary>
        /// <param name="AmountSalariTheForThePeriodIn"> Выводит сумму заработка за выбранный период  </param>
        /// <param name="TheAmountOfPaymentForAnApartmentOrHouseInThePeriod"> Выводит сумму оплаты квартиры или дома за выбранный период </param>
        /// <param name="TheAmountOfPaymentForMealsDuringThePeriod"> Выводит сумму оплаты питания за выбранный период</param>
        /// <param name="Budget_of_funds_for_other_expenses_per_month">Выводит остаток от суммы на прочие расходы за выбранный период</param>
        /// <param name="Amount_piggy_bank_the_month"> Выводит сумму копилкиза выбранный период</param>

        static void Financial_condition_the_month(decimal AmountSalariTheForThePeriodIn,
                                                  decimal TheAmountOfPaymentForAnApartmentOrHouseInThePeriod,
                                                  decimal TheAmountOfPaymentForMealsDuringThePeriod,
                                                  decimal Budget_of_funds_for_other_expenses_per_month,
                                                  decimal Amount_piggy_bank_the_month,
                                                  decimal month)
        {
            Console.WriteLine();
            Console.WriteLine($"Сумма месячной зарплаты в периоде {month} месяце: {AmountSalariTheForThePeriodIn} ");
            Console.WriteLine($"Сумма оплаты за квартиру в периоде {month} месяцев : {TheAmountOfPaymentForAnApartmentOrHouseInThePeriod} ");
            Console.WriteLine($"Сумма оплаты за еду в перриоде {month} месяцев : {TheAmountOfPaymentForMealsDuringThePeriod} ");
            Console.WriteLine($"Сумма оставшиеся на прочие денежные растраты в периоде {month} месяцев : {Budget_of_funds_for_other_expenses_per_month} ");
            Console.WriteLine($"Сумма финансовой копилки в периоде {month} месяцев : {Amount_piggy_bank_the_month} ");
            Console.WriteLine();

        }

        

       
        /// <summary>
        /// Рассчитывания затратов и прибыли на месяц
        /// </summary>
        /// <param name="amountReceived"></param>

        static void CalculationOfFinancestheTheMonth(AmountReceived amountReceived)
        {
            Console.WriteLine("");

       //     bool CheckingValues 

            decimal Amount_Salari_the_month = amountReceived.Monthly_salary_amount;
            decimal Amount_payment_apartment_or_house_the_month = amountReceived.The_amount_of_payment_for_an_apartment_or_house;
            decimal Amount_payment_food_the_month = amountReceived.Payment_amount_for_food;




            string NumberOfMonths;
            {
                bool DateOfTheMonthCorrect;

                do
                {
                    Console.Write("Введите за какой на период хотите расчитать финансы / от 1 до 12 месяцев : ");
                    NumberOfMonths = Console.ReadLine();
                    {
                        const string TheFirstMonth_CODE = "1", SecondMonth_CODE = "2", ThirdMonth_CODE = "3", FourthMonth_CODE = "4",
                                     FifthMonth_CODE = "5", SixthMonth_CODE = "6", SeventhMonth_CODE = "7", EighthMonth_CODE = "8",
                                     NinthMonth_CODE = "9", TenthMonth_CODE = "10", EleventhMonth_CODE = "11", TwelfthMonth_CODE = "12";

                        switch (NumberOfMonths)
                        {
                            case TheFirstMonth_CODE:
                            case SecondMonth_CODE:
                            case ThirdMonth_CODE:
                            case FourthMonth_CODE:
                            case FifthMonth_CODE:
                            case SixthMonth_CODE:
                            case SeventhMonth_CODE:
                            case EighthMonth_CODE:
                            case NinthMonth_CODE:
                            case TenthMonth_CODE:
                            case EleventhMonth_CODE:
                            case TwelfthMonth_CODE:
                                {
                                    DateOfTheMonthCorrect = true;
                                    break;
                                }
                            default:
                                {
                                    DateOfTheMonthCorrect = false;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Вы ввели несуцествующий период месяца: {NumberOfMonths}! ");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;
                                }
                        }
                    }
                }
                while (DateOfTheMonthCorrect == false);
            }


            decimal month;
            {
                const string TheFirstMonth_CODE = "1", SecondMonth_CODE = "2", ThirdMonth_CODE = "3", FourthMonth_CODE = "4",
                                 FifthMonth_CODE = "5", SixthMonth_CODE = "6", SeventhMonth_CODE = "7", EighthMonth_CODE = "8",
                                 NinthMonth_CODE = "9", TenthMonth_CODE = "10", EleventhMonth_CODE = "11", TwelfthMonth_CODE = "12";

                switch (NumberOfMonths)
                {
                    case TheFirstMonth_CODE:
                        {
                            const decimal TheFirstMonth_MONTH = 1;
                            month = TheFirstMonth_MONTH;
                            break;
                        }
                    case SecondMonth_CODE:
                        {
                            const decimal SecondMonth_MONTH = 2;
                            month = SecondMonth_MONTH;
                            break;
                        }
                    case ThirdMonth_CODE:
                        {
                            const decimal FourthMonth_MONTH = 3;
                            month = FourthMonth_MONTH;
                            break;
                        }
                    case FourthMonth_CODE:
                        {
                            const decimal FourthMonth_MONTH = 4;
                            month = FourthMonth_MONTH;
                            break;
                        }
                    case FifthMonth_CODE:
                        {
                            const decimal FifthMonth_MONTH = 5;
                            month = FifthMonth_MONTH;
                            break;
                        }
                    case SixthMonth_CODE:
                        {
                            const decimal SixthMonth_MONTH = 6;
                            month = SixthMonth_MONTH;
                            break;
                        }
                    case SeventhMonth_CODE:
                        {
                            const decimal SeventhMonth_MONTH = 7;
                            month = SeventhMonth_MONTH;
                            break;
                        }
                    case EighthMonth_CODE:
                        {
                            const decimal EighthMonth_MONTH = 8;
                            month = EighthMonth_MONTH;
                            break;
                        }
                    case NinthMonth_CODE:
                        {
                            const decimal NinthMonth_MONTH = 9;
                            month = NinthMonth_MONTH;
                            break;
                        }
                    case TenthMonth_CODE:
                        {
                            const decimal TenthMonth_MONTH = 10;
                            month = TenthMonth_MONTH;
                            break;
                        }
                    case EleventhMonth_CODE:
                        {
                            const decimal EleventhMonth_MONTH = 11;
                            month = EleventhMonth_MONTH;
                            break;
                        }
                    case TwelfthMonth_CODE:
                        {
                            const decimal TwelfthMonth_MONTH = 12;
                            month = TwelfthMonth_MONTH;
                            break;
                        }
                    default:
                        {
                            month = 0;
                            break;
                        }


                }
            }


            

            decimal AmountSalariTheForThePeriodIn = Amount_Salari_the_month * month;
            decimal TheAmountOfPaymentForAnApartmentOrHouseInThePeriod = Amount_payment_apartment_or_house_the_month * month;
            decimal TheAmountOfPaymentForMealsDuringThePeriod = Amount_payment_food_the_month * month;




            decimal Amount_30_Pct_the_piggy_bank;
            Amount_30_Pct_the_piggy_bank = 30;//% отправляемый в финансовою копилку от общей суммы
            decimal Amount_piggy_bank_the_month = ((Amount_Salari_the_month * month) / 100 * Amount_30_Pct_the_piggy_bank);
            decimal Budget_of_funds_for_other_expenses_per_month = ((Amount_Salari_the_month * month) -
                (Amount_payment_apartment_or_house_the_month * month) - (Amount_payment_food_the_month * month)
                - Amount_piggy_bank_the_month);

            Financial_condition_the_month(AmountSalariTheForThePeriodIn, TheAmountOfPaymentForAnApartmentOrHouseInThePeriod,
                                          TheAmountOfPaymentForMealsDuringThePeriod, Budget_of_funds_for_other_expenses_per_month,
                                          Amount_piggy_bank_the_month, month);
            //рассчитывания затратов и прибыли на месяц

        }


        static void Main(string[] args)
        {
            var FirstMouth = EstimatedAmount();

            CalculationOfFinancestheTheMonth(FirstMouth);


            Console.ReadLine();
        }
    }
}