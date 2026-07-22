class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        hm = {}
        i = 0
        while head:
            hm[i] = head
            head = head.next
            i += 1

        length = i
        hm2 = [None] * (length)  # Cria uma lista com o tamanho adequado
        countEven = 0
        countOdd = 0

        for i in range(length):  # Ajuste conforme iterável correto
            if i == 0:
                hm2[0] = hm.get(i)
            elif i % 2 == 0:
                countEven += 1
                hm2[i] = hm.get(countEven)
            else:
                countOdd += 1
                hm2[i] = hm.get(length - countOdd)

        dummyNode = ListNode()
        node = dummyNode
        for item in hm2:
            node.next = item
            node = node.next
        node.next = None  

        head = dummyNode.next