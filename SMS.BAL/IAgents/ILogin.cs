using SMS.Model;

namespace SMS.BAL.IAgents
{
    public interface ILogin
    {
        /// <summary>
        /// Checks entered userid and password is correct or not
        /// </summary>
        /// <param name="loginDetails"></param>
        /// <returns>Boolean Value</returns>
        bool IsCredentialValid(LoginDetails loginDetails);

        /// <summary>
        /// Check if Userid is alredy present in record
        /// </summary>
        /// <param name="loginDetails"></param>
        /// <returns></returns>
        bool IsAlreadyExist(SignupDetails signupDetails);
    }
}
