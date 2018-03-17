using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClient.RemoteReference;

namespace TestClient {
    class Program {
        static void Main(string[] args) {
            // помощник вывода в консоль
            ConsoleWriter writer = new ConsoleWriter();

            // создадим клиент сервиса
            CalculatorClient client = new CalculatorClient("BasicHttpBinding_ICalculator");

            try {
                // проверка соединения
                writer.Write("Проверка соединения с сервисом... ");
                if (!string.Equals(client.TestConnection(), "OK", StringComparison.InvariantCultureIgnoreCase)) {
                    throw new Exception("Проверка соединения не удалась");
                }
                writer.WriteLineSuccess();
                writer.WriteLine();

                // лямбда-функция проверки метода
                var CheckArithmeticOperation = new Action<Func<double, double, double>, string, double, double, double>
                (
                    (operation, operationName, arg1, arg2, expectedResult) => {
                        writer.Write("Проверка операции '");
                        writer.Write(ConsoleColor.White, operation.Method.Name);
                        writer.Write("', {0} {1} {2} = ", arg1.ToString(CultureInfo.InvariantCulture), operationName, arg2.ToString(CultureInfo.InvariantCulture));
                        double result = operation(arg1, arg2);
                        if (result == expectedResult) {
                            // проверка пройдена
                            writer.Write("{0} ", result.ToString(CultureInfo.InvariantCulture));
                            writer.WriteLineSuccess();
                        }
                        else {
                            // ошибка
                            throw new Exception(string.Format("Ошибка проверки метода '{0}': {1} {2} {3} != {4}",
                                operation.Method.Name, arg1.ToString(CultureInfo.InvariantCulture), operationName, arg2.ToString(CultureInfo.InvariantCulture), expectedResult.ToString(CultureInfo.InvariantCulture)));
                        }
                    }
                );

                // проверка метода Addition
                CheckArithmeticOperation(client.Addition, "+", 2.5, 5, 2.5 + 5);

                // проверка метода Subtraction
                CheckArithmeticOperation(client.Subtraction, "-", 2.5, 5, 2.5 - 5);

                // проверка метода Multiplication
                CheckArithmeticOperation(client.Multiplication, "*", 2.5, 5, 2.5 * 5);

                // проверка метода Division
                CheckArithmeticOperation(client.Division, "/", 2.5, 5, 2.5 / 5);

                // в конце работы закрываем клиент
                client.Close();
            }
            catch (Exception ex) {
                // в случае ошибки необходимо принудительно закрыть клиент методом Abort()
                client.Abort();

                // выводим информацию об ошибке
                writer.WriteLine();
                writer.WriteLineError("Ошибка: {0}", ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}