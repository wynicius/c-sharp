int result = Calculator.Sum(10, 20, 30, 40); // com a inserção de params, passar parâmetros se torna mais fácil

namespace Course {
    class Calculator {
        public static int Sum(params int[] numbers) { // inserção de params
        int sum = 0;
        for (int i=0; i<numbers.Length; i++) {
            sum += numbers[i];
        }
        return sum;
        }
    }
}

// RESOLUÇÃO SEM PARAMS, ABAIXO:

// int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });

// namespace Course {
//     class Calculator {
//         public static int Sum(int[] numbers) {
//         int sum = 0;
//         for (int i=0; i<numbers.Length; i++) {
//             sum += numbers[i];
//         }
//         return sum;
//         }
//     }
// }

// namespace Course {
//     class Calculator {
//         public static int Sum(int n1, int n2) {
//             return n1 + n2;
//         }
//         public static int Sum(int n1, int n2, int n3) {
//             return n1 + n2 + n3;
//         }
//         public static int Sum(int n1, int n2, int n3, int n4) {
//             return n1 + n2 + n3 + n4;
//         }
//     }
// }