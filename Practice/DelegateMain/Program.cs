using Delegates;

cal calOpen = new cal(Calculation.Subtraction);
calOpen(5, 4);
calOpen.Invoke(5, 8);
calOpen -= Calculation.Multiplication;
calOpen(80, 60);

