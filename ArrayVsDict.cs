using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace LearningAlgos{
    public class ArrayVsDict{
        private int[]? _testArray; 
        private int _sampleStart = 100;
        private int _sampleEnd = 101; 
        public List<int> paramsArr => GetParams(_sampleStart,
                                                _sampleEnd);

        [ParamsSource(nameof(paramsArr))]
        public int TestInt;
        
        [GlobalSetup]
        public void Setup(){
            _testArray = new int[TestInt];
            _testArray[TestInt-1] = TestInt;
        }

        [Benchmark]
        public int GetElementFromArray(){
            for(var i = 0; i < TestInt; i++){
                if(_testArray[i] == TestInt){
                   return _testArray[i]; 
                }
            }
            return 0;
        }
        
        public static List<int> GetParams(int sampleStart,
                                          int sampleEnd){
            var sample = new List<int>();
            for(var i = sampleStart; i <= sampleEnd; i++){
                sample.Add(i);
            }
            return sample;
        }
    }
}
