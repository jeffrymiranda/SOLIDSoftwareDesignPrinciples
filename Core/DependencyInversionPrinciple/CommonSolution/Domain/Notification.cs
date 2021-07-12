namespace Core.DependencyInversionPrinciple.CommonSolution.Domain
{
    public class Notification
    {
        private Email email;

        public Notification()
        {
            email = new Email();
        }

        public void sendPromotion()
        {
            email.sendEmail();
        }
    }
}
