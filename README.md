# 421GroupStatsCalc
[![Build Status](https://travis-ci.org/swarrier16/421GroupStatsCalc.svg?branch=master)](https://travis-ci.org/swarrier16/421GroupStatsCalc)

## Project Outline
Calculator Object
### 1)	Properties <br>
   &nbsp;&nbsp; i)	Result <br>
### 2)	basicCalculator class <br>
  &nbsp;&nbsp; a)	Methods <br>
    &nbsp;&nbsp;&nbsp;&nbsp; i)	Addition (Nicole) <br> 
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (1)	Calls addition static method from math operations<br>
    &nbsp;&nbsp;&nbsp;&nbsp; ii)	Subtraction (Rati) <br> 
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (1)	Calls subtraction static method from Math operations<br>
    &nbsp;&nbsp;&nbsp;&nbsp; iii)	Multiplication (Shruti) <br> 
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	 Call multiplication static method from Math operations <br>
    &nbsp;&nbsp;&nbsp;&nbsp; iv)	Division (Nicole) <br> 
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (1)	 Call division static method from Math operations<br>
    &nbsp;&nbsp;&nbsp;&nbsp; v)	Square (Rati) <br> 
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (1)	 Call square static method from Math operations <br>
    &nbsp;&nbsp;&nbsp;&nbsp; vi)	Square Root (Shruti) <br> 
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Call square root method from Math operations <br>
### 3)	Math Operations Static Class <br>
  &nbsp;&nbsp;a)	Methods <br>
   &nbsp;&nbsp;&nbsp;&nbsp;  i)	Addition (Nicole) <br>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (1)	Calls addition class method of Sum <br>
    &nbsp;&nbsp;&nbsp;&nbsp; ii)	Subtraction (Rati) <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Calls subtraction class method of Difference <br>
    &nbsp;&nbsp;&nbsp;&nbsp;iii)	Multiplication (Shruti) <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Call multiplication class method of Product <br>
    &nbsp;&nbsp;&nbsp;&nbsp;iv)	Division (Nicole) <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Call division class method of Quotient <br>
    &nbsp;&nbsp;&nbsp;&nbsp;v)	Square (Rati) <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Call square class method of Power <br>
   &nbsp;&nbsp;&nbsp;&nbsp; vi)	Square Root (Shruti) <br>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (1)	Call square root class method of Root <br>
### 4)	Operations classes <br>
&nbsp;&nbsp;a)	Addition (Nicole) <br>
&nbsp;&nbsp;&nbsp;&nbsp;i)	Methods <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Sum 2 numbers <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(2)	Sum list of numbers <br>
&nbsp;&nbsp;b)	Subtraction (Rati) <br>
&nbsp;&nbsp;&nbsp;&nbsp;i)	Methods <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Subtract 2 numbers <br>
&nbsp;&nbsp;c)	Multiplication (Shruti) <br>
&nbsp;&nbsp;&nbsp;&nbsp;i)	Methods <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Multiply 2 numbers <br>
&nbsp;&nbsp;d)	Division (Nicole)<br>
&nbsp;&nbsp;&nbsp;&nbsp;i)	Methods <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Divide 2 numbers <br>
&nbsp;&nbsp;e)	Square (Rati) <br>
&nbsp;&nbsp;&nbsp;&nbsp;i)	Methods <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Square a number <br>
&nbsp;&nbsp;f)	Square Root (Shruti) <br>
&nbsp;&nbsp;&nbsp;&nbsp;i)	Methods <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Take the square root of a number <br>
### 5)	Statistics Functions <br>
&nbsp;&nbsp;a)	Descriptive Statistics <br>
&nbsp;&nbsp;&nbsp;&nbsp;i)	Methods <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Mean (Nicole)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Addition class to Sum numbers <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Division class to divide by the number of items <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(2)	Median (Rati) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Addition class to Sum numbers <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Division class to divide by the number of items (if even) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(3)	Mode (Shruti) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(4)	Variance (Nicole) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Mean method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Add method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(c)	Call Divide method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(5)	Standard Deviation (Nicole) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Variance Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Square Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(6)	Skewness (Shruti) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Multiplication Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Mean Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(c)	Call Median Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(d)	Call Standard Deviation Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(e)	Call Division Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(7)	Sample Coefficient (Rati) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Mean method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Standard Deviation Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(c)	Call Multiplication Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(8)	Population Coefficient (Shruti) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Mean method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Standard Deviation Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(c)	Call Multiplication Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(d)	Call Division Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(9)	Mean Deviation (Shruti)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Mean Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Division Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(10)	Z-Score (Nicole) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Mean Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Std Dev Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(11)	Quartiles (Nicole) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;b)	Population Statistics <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;i)	Methods <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Simple Random Sample (Shruti) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Quotient method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(2)	Systematic Sampling (Shruti) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Quotient method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(3)	Margin of Error (Nicole) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Std Dev method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Z-Score method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(c)	Call Quotient Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(4)	Confidence Interval (Rati) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Mean Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Margin of Error Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(5)	Cochran Formula (Rati) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(a)	Call Z-Score Function <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(b)	Call Margin of Error Function <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(c)	Call Power Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(d)	Call Quotient Method <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(6)	How to Find a Sample Size Given a Confidence Interval and Width (unknown population standard deviation) (Rati) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(7)	How to Find a Sample Size Given a Confidence Interval and Width (known population standard deviation) (Rati) <br>
### 6)	Random Class (Shruti)<br>
&nbsp;&nbsp;a)	Methods <br>
&nbsp;&nbsp;&nbsp;&nbsp;i)	Generate a random number without a seed between a range of two numbers <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Integer <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(2)	Decimal <br>
&nbsp;&nbsp;&nbsp;&nbsp;ii)	Generate a random number with a seed between a range of two numbers <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Integer <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(2)	Decimal <br>
&nbsp;&nbsp;&nbsp;&nbsp;iii)	Generate a list of N random numbers with a seed and between a range of numbers  <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(1)	Integer <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(2)	Decimal <br>
&nbsp;&nbsp;&nbsp;&nbsp;iv)	Select a random item from a list <br>
&nbsp;&nbsp;&nbsp;&nbsp;v)	Set a seed and randomly select the same value from a list <br>
&nbsp;&nbsp;&nbsp;&nbsp;vi)	Select N number of items from a list without a seed <br>
&nbsp;&nbsp;&nbsp;&nbsp;vii)	Select N number of items from a list with a seed <br>

<hr>

