namespace POC.StateMachine
{
    public enum StateTransitionEnum
    {
        INVALID,
        S00_S01,
        S00_S10,
        S01_S00,
        S01_S11,
        S10_S00,
        S10_S11,
        S11_S01,
        S11_S10
    }
}