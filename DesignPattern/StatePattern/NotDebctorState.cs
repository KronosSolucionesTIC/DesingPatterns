namespace DesignPatterns.StatePattern
{
    public class NotDebctorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            if(amount <= customerContext.Residue)
            {
                customerContext.Discount(amount);
                Console.WriteLine($"Accion permitida, gasta {amount}, y el saldo es {customerContext.Residue}");
                if (customerContext.Residue <= 0)
                    customerContext.SetState(new DebtorState());
            } else
            {
                Console.WriteLine($"No ajustas lo solicitado " +
                    $"ya que tienes {customerContext.Residue} " +
                    $"y quieres gastar {amount}");
            }
        }
    }
}
