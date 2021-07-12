namespace Core.DependencyInversionPrinciple.SOLIDSolution.Domain
{
    public class Notification
    {
        private IMessenger iMessenger;
        public Notification(IMessenger messenger)
        {
            iMessenger = messenger;
        }
        public void sendPromotion()
        {
            iMessenger.sendMessage();
        }
    }
}
