using Plugin.NFC;

namespace CallingCard
{
    public partial class MainPage : ContentPage
    {
        const string _vcard = @"BEGIN:VCARD
VERSION:3.0
FN:Rob Prouse
ORG:Valsoft / Aspire 
ADR:;;175 Beach Blvd\, Hamilton ON L8H 6V8 ;;;;;
TEL:905-320-7861
EMAIL:rob@prouse.org
URL:https://8bitlabs.ca
END:VCARD";

        public MainPage()
        {
            InitializeComponent();

            // Event raised when a ndef message is received.
            CrossNFC.Current.OnMessageReceived += Current_OnMessageReceived;

            // Event raised when a ndef message has been published.
            CrossNFC.Current.OnMessagePublished += Current_OnMessagePublished;

            // Event raised when a tag is discovered. Used for publishing.
            CrossNFC.Current.OnTagDiscovered += Current_OnTagDiscovered;

            // Event raised when NFC listener status changed
            CrossNFC.Current.OnTagListeningStatusChanged += Current_OnTagListeningStatusChanged;
        }

        private void Current_OnMessageReceived(ITagInfo tagInfo)
        {
        }

        private void Current_OnMessagePublished(ITagInfo tagInfo)
        {
        }

        private void Current_OnTagDiscovered(ITagInfo tagInfo, bool format)
        {
        }

        private void Current_OnTagListeningStatusChanged(bool isListening)
        {
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            CrossNFC.Current.StartListening();
        }
    }

}
