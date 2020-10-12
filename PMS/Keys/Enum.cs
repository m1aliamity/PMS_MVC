namespace PMS.Keys
{
    public enum AlertType
    {
        SUCCESS,
        DANGER,
        WARNING
    }
    public static class AlertColor
    {
        public static string SUCCESS = "BootstrapDialog.TYPE_SUCCESS";
        public static string WARNING = "BootstrapDialog.TYPE_WARNING";
        public static string ERROR = "BootstrapDialog.TYPE_DANGER";
        //DEFAULT = "BootstrapDialog.TYPE_DEFAULT", // 'Information';
        //INFO = "BootstrapDialog.TYPE_INFO", //'Information';
        //PRIMAR = "BootstrapDialog.TYPE_PRIMARY", //= 'Information';
        //SUCCESS = "BootstrapDialog.TYPE_SUCCESS",// = 'Success';
        //WARNING = "BootstrapDialog.TYPE_WARNING", //= 'Warning';
        //ERROR = "BootstrapDialog.TYPE_DANGER"// = 'Danger';
    }
}