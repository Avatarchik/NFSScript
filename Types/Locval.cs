namespace NFSScript
{
    /// <summary>
    /// 
    /// </summary>
    public struct Locval
    {
        /// <summary>
        /// 
        /// </summary>
        public int value { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public Locval(int value)
        {
            this.value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        public static implicit operator int(Locval instance)
        {
            return instance.value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Locval(int value)
        {
            return new Locval(value);
        }
    }
}
