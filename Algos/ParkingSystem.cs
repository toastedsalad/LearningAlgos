namespace LearningAlgos;

public class ParkingSystem {
    public int BigSpaceLeft { get; set; }
    public int MedSpaceLeft { get; set; }
    public int SmallSpaceLeft { get; set; }

    public ParkingSystem(int big, int medium, int small) {
        BigSpaceLeft = big;
        MedSpaceLeft = medium;
        SmallSpaceLeft = small;
    }
    
    public bool AddCar(int carType) {
        if (carType == 1 && BigSpaceLeft != 0) {
            BigSpaceLeft -= 1;
            return true;
        } else if (carType == 2 && MedSpaceLeft != 0) {
            MedSpaceLeft -= 1;
            return true;
        } else if (carType == 3 && SmallSpaceLeft != 0) {
            SmallSpaceLeft -= 1;
            return true;
        } else {
            return false;
        }
    }
}
