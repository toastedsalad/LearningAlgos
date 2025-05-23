using System.Collections.Generic;

namespace LearningAlgos;

public class BuddyString {
    public bool BuddyStrings(string s, string goal) {
        // What letters are available in goal?
        var availableLetters = new Dictionary<char, int>(){};
        for (var i = 0; i < goal.Length; i++) {
            if (goal.Contains(s[i])) {
                if (availableLetters.ContainsKey(s[i])) {
                    return true;
                }
                availableLetters.Add(s[i], i);
            }
        }

        foreach (var letter1 in availableLetters) {
            availableLetters.Remove(letter1.Key);
            foreach (var letter2 in availableLetters) {
                var inter = s.ToCharArray();
                inter[letter1.Value] = letter2.Key; 
                inter[letter2.Value] = letter1.Key; 
                var newString = new string(inter);
                if (newString == goal) {
                    return true;
                }
            } 
        }
        return false;
    }
}
