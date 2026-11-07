class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        if not grid:
            return 0

        rows, cols = len(grid), len(grid[0])
        islands = 0

        def BFS(r, c):
            q = collections.deque()

            grid[r][c] = '0' 
            q.append((r,c))

            while q:
                s = q.popleft()
                row, col = s[0], s[1]

                coordinates = {(0,1), (0,-1), (1,0), (-1,0)}

                for coord in coordinates:
                    new_r = row+coord[0] if row+coord[0] < rows and row+coord[0] >= 0 else None
                    new_c = col+coord[1] if col+coord[1] < cols and col+coord[1] >= 0 else None

                    if (new_r is not None and new_c is not None) and grid[new_r][new_c] == '1':
                        grid[new_r][new_c] = '0'
                        q.append((new_r, new_c))
                        

        #-------------------
        #Find any valid coordinate of an island

        #Itirate through each to find valid island, then run BFS
        for r in range(rows):
            for c in range(cols):
                if grid[r][c] == "1":
                    BFS(r , c)
                    islands += 1

        return islands