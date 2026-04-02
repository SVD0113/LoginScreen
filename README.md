# (C# 코딩) 로그인스크린


## 개요
-C# 프로그래밍학습

-1줄소개: 아이디와 패스워드 입력을 받아 로그인을 하는 창

-사용한플랫폼: 
    -C#, .NET Windows Forms, Visual Studio, GitHub

-사용한컨트롤:
    - Label, TextBox, Button, visible

-사용한기술과구현한기능: 
    - string 변수로 ID와 PW를 각 설정
    - if-else문으로 ID와 PW 모두 일치할 때 로그인 / 그렇지않으면 로그인 실패
    - UseSystemPasswordChar로 PW는 *처리하여 비번을 가림
    - KeyDown 이벤트에서 Enter 입력을 받으면 ID->PW, PW->버튼클릭 실행



## 실행화면(과제1)

-과제1 코드의 실행 스크린샷
![과제1 실행화면] <img width="535" height="476" alt="로그인 성공" src="https://github.com/user-attachments/assets/3e55673e-0353-4ccb-96db-ff6c8d8c3989" />

![과제1 실행화면] <img width="526" height="475" alt="로그인 실패" src="https://github.com/user-attachments/assets/4d1cfefa-41fd-453e-917c-832117318fe6" />


-과제 내용
    - 로그인과 비번 변수를 설정하여 로그인/로그인 실패 창을 생성함. Enter로 키를 넘기고 btn을 실행하는 등의 편의 기능까지 구현함.

-구현 내용과 기능 설명
    - string 변수로 ID와 PW를 각 설정
    - if-else문으로 ID와 PW 모두 일치할 때 로그인 / 그렇지않으면 로그인 실패
    - UseSystemPasswordChar로 PW는 *처리하여 비번을 가림
    - KeyDown 이벤트에서 Enter 입력을 받으면 ID->PW, PW->버튼클릭 실행



    ## 실행화면(과제2)

-과제2 코드의 실행 스크린샷
![과제2 실행화면] <img width="535" height="471" alt="실패 메시지" src="https://github.com/user-attachments/assets/a07a2f21-e5b0-4661-90f7-2c9517b2846e" />


-과제 내용
    - 로그인 실패 시 에러 메시지 보여주기 / MessageBox 띄우지 않고 보여주기

-구현 내용과 기능 설명
    - Visible을 활용하여 메시지를 특정 상황에 나왔다없어졌다 조절.
    - if-else문에서 else(실패)일 때 MessageBox.Show를 활용하여 메시지 박스로 실패 확인을 눌러야 다음이 진행할 수 있게끔 만듬.




    ## 실행화면(과제3)

-과제3 코드의 실행 스크린샷
![과제3 실행화면] <img width="530" height="476" alt="과제3" src="https://github.com/user-attachments/assets/38377c29-4b11-469d-bfb3-e88de924f202" />


-과제 내용
    - text입력 메시지 삭제 버튼 구현
    - 패스워드 *를 보이게하는 버튼 구현

-구현 내용과 기능 설명
    - !(not)문으로 토글 버튼으로 구현하여 패스워드를 볼 수 있게끔 구현.
    - X버튼을 만들어 ID/PW를 ""으로 만들어 쓴 내용을 지울 수 있게끔 구현.
    
