# OOP


<h3> 객체지향 프로그래밍 Report </h3>

우선 두 스택 모두 특정 자료형만 들어갈 수 있는 것이 아닌 모든 자료형이 들어갈 수 있게 object 타입으로 스택을 구현했습니다.

1. 배열로 스택 구현하기<br>
push, pop, peek 세 개의 메소드로 구성이 되어있습니다. 각각 data를 추가, 삭제, 스택의 탑을 확인하는 메소드들 입니다. <br>
top이라는 정수형 변수에 -1을 할당하고 push가 될 때마다 top을 +1 pop이 될 때 마다 -1을 해줍니다. 그렇다면 첫 데이터가 삽입될 때는 top이 0이 되면서 배열의 첫번째부터 데이터가 들어가게 됩니다.
peek의 경우 현재 스택의 최상단 데이터를 보여주는 메소드로 스택으로 사용하는 배열 arrStack[top]을 출력하면 탑의 data가 나오게 됩니다. 또한 pop될 때 top의 값이 -1이라면 스택이 비어있다는 뜻이니 스택이 비어있다는 스트링을 출력하고 peek 역시 마찬가지로 top이 -1이라면 스택이 비어있다고 출력을 합니다
<img width="368" alt="image" src="https://user-images.githubusercontent.com/100292629/227708059-96c6c10b-c7ce-451e-bfca-837b3011bdb8.png">





2. 링크드리스트로 스택 구현하기<br>
구현되어 있는 메소드는 배열로 스택을 구현한 메소드와 같습니다. <br>
클래스는 Main메소드가 돌아가는 Program 클래스, 이전 노드의 주소와 현재 노드의 데이터를 저장하는 Node 클래스, push, pop, peek를 가지고 있는 Linkedliststack 클래스로 총 3개의 클래스로 나눠져 있습니다. <br>

각 클래스의 instance 변수로는 Node클래스에 사용자가 입력한 데이터를 저장하는 data라는 변수, 이전 노드의 주소를 가리키는 before라는 변수가 있고, Linkedliststack클래스에는 top이라는 현재의 top의 주소를 가리키는 Node타입의 instance변수가 존재합니다.

push의 경우 새로운 노드 객체를 생성하고 <img width="178" alt="image" src="https://user-images.githubusercontent.com/100292629/227709238-5a669f8b-7907-4527-8464-cd31f816f01f.png"> 새로운 노드의 이전 주소를 top을 가리키게 하고 새로운 노드는 top이 되게 한다면 스택의 push와 똑같이 만들 수 있습니다. <br>

pop의 경우 top의 값이 null이라면 아무것도 참조하고 있지 않다는 소리로 스택이 비어있다는 소리입니다. 그리고 null이 아니라면 스택에 하나 이상은 들어있다는 소리이니 top = top.before로 탑의 이전주소를 탑이 가리키게 되면 탑이 변경되고 주소가 끊기게 되니 성공적으로 pop이 수행됩니다. <br>

peek의 경우 pop과 마찬가지로 top이 null이라면 스택이 비어있다는 소리이므로 스택이 비어있다고 출력하고, 그렇지 않다면 top.data를 출력합니다.


<img width="407" alt="image" src="https://user-images.githubusercontent.com/100292629/227708204-36d96b2a-3994-4cbb-96fc-86bc965433bc.png">
