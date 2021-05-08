namespace _03Druid
{
    public enum DirectionType
    {
        //假设初始状态向北行进

        /// <summary>
        /// 右转一次(左转三次)
        /// </summary>
        East,

        /// <summary>
        /// 右转两次(左转两次)
        /// </summary>
        South,

        /// <summary>
        /// 右转三次(左转一次)
        /// </summary>
        West,

        /// <summary>
        /// 右转四次(左转四次)  旋转360度后，和原来保持一致
        /// </summary>
        North
    }
}
