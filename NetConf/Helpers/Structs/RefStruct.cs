namespace NetConf.Helpers.Structs
{
    ref struct RefStruct
    {
        public string GetValue(){
            return "Value";
        }
        public void Dispose()
        {
            // release unmanaged resources
        }
    }
}