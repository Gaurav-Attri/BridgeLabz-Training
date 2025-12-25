using System;
class OTPGenerator{
    static Random Rand = new Random();
    static void Main(string[] args){
        int[] otps = new int[10];

        for (int i = 0; i < 10; i++){
            otps[i] = GenerateOTP();
        }

        for (int i = 0; i < 10; i++){
            Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
        }

        if (AreOTPsUnique(otps)){
            Console.WriteLine("All OTPs are unique");
        }
        else{
            Console.WriteLine("Duplicate OTPs found");
        }
    }

    static int GenerateOTP(){
        return Rand.Next(100000, 1000000);
    }

    static bool AreOTPsUnique(int[] otps){
        for (int i = 0; i < 10; i++){
            for (int j = i + 1; j < 10; j++){
                if (otps[i] == otps[j]){
                    return false;
                }
            }
        }
        return true;
    }
}
