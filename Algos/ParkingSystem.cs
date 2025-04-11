namespace LearningAlgos;

public class ParkingSystem {
    private int _bigSpaceLeft;
    private int _medSpaceLeft; 
    private int _smallSpaceLeft;

    public ParkingSystem(int big, int medium, int small) {
        _bigSpaceLeft = big;
        _medSpaceLeft = medium;
        _smallSpaceLeft = small;
    }
    
    public bool AddCar(int carType) {
        if (carType == 1 && _bigSpaceLeft != 0) {
            _bigSpaceLeft -= 1;
            return true;
        } else if (carType == 2 && _medSpaceLeft != 0) {
            _medSpaceLeft -= 1;
            return true;
        } else if (carType == 3 && _smallSpaceLeft != 0) {
            _smallSpaceLeft -= 1;
            return true;
        } else {
            return false;
        }
    }
}

