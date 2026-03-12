# 1주차 과제: 나만의 디지털 명함 제작
- 이름: 김건우 (25010012)

- 핵심기능: 버튼도망, 버튼 잡았을 시 메시지 박스, 점수 표시, 난이도 조절, 게임 오버, 다시시작 버튼

## 실행 화면
기본 실행화면

<img width="403" height="253" alt="스크린샷 2026-03-12 오후 4 37 51" src="https://github.com/user-attachments/assets/5cc9505c-e5f8-42a3-a94c-4a9bfc3168ff" />



# 1단계

<img width="403" height="254" alt="스크린샷 2026-03-12 오후 4 39 05" src="https://github.com/user-attachments/assets/06a3d3e6-83f9-4749-8887-7cff343aaaf4" />

마우스 접근시 버튼이 움직이면서 Title Bar에 버튼 위치가 표시됨



# 2단계

<img width="403" height="256" alt="스크린샷 2026-03-12 오후 5 14 21" src="https://github.com/user-attachments/assets/67fb6390-47cb-4765-a5c4-6c9571f736fb" />

버튼을 잡았을 때 버튼을 클릭하면 “축하합니다~!” 라고 메시지 박스 표시




# 3단계

<img width="227" height="34" alt="스크린샷 2026-03-12 오후 5 16 33" src="https://github.com/user-attachments/assets/d8969bcd-fc26-4be3-8598-8433111a4e0f" />

폼 제목에 점수 표시

<img width="404" height="254" alt="스크린샷 2026-03-12 오후 5 17 03" src="https://github.com/user-attachments/assets/1340f6bb-8913-4cd0-89bd-3ad115384339" />

<img width="402" height="255" alt="스크린샷 2026-03-12 오후 5 17 24" src="https://github.com/user-attachments/assets/d626f6ef-c71d-46a4-8986-88ff1ae51651" />

난도 조절을 위해 성공시 10% 크기 축소




# 4단계

<img width="402" height="254" alt="스크린샷 2026-03-12 오후 5 18 14" src="https://github.com/user-attachments/assets/a51a4842-3b14-4c4a-802e-44741ec7c489" />

20회 실패시 "GameOver" 출력, 모든 버튼 비활성화

<img width="141" height="69" alt="스크린샷 2026-03-12 오후 5 19 25" src="https://github.com/user-attachments/assets/f10c1fb2-7adc-4fc5-8e38-27b3d9c5608c" />

다시시작 버튼으로 점수와 버튼 크기를 초기화 하여 게임을 처음부터 다시 시작할 수 있게 함




## 구현 시 어려웠던 점
- 처음에 단순히 폼의 전체 크기 안에서 random좌표를 생성 했더니 버튼이 폼 밖으로 나가버리는 버그 발견. 이를 해결하기 위해 최대 이동 가능 범위(maxX, maxY)를 계산해서 버튼이 화면 안에 머물도록 처리함.

- 3단계, 4단계에서 score and miss를 카운트하는 과정에서 변수의 스코프(Scope) 지정에 어려움을 겪음. 처음에 이벤트 핸들러 내부에 변수를 선언했다가 마우스가 닿을 때마다 값이 0으로 초기화되는  오류를 발견함. 이벤트 기반 프로그래밍에서는 상태를 계속 유지해야 하므로, 해당 변수들을 메서드 내부가 아닌 클래스의 멤버 변수로 선언하여 데이터가 문제없이 누적되도록함
