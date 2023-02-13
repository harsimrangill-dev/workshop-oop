string[] lines = File.ReadAllLines("file.txt");
            
            list<string> file = new List<string>();

            foreach (string line in file) 
            {
                int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0, i = 0, j = 0, k = 0, l = 0, m = 0, n = 0, o = 0, p = 0, q = 0, r = 0, s = 0, t = 0, u = 0, v = 0,w =0, x = 0, y = 0, z = 0;
                for(int i = 0 ; i < lines.Length; i++)
                {
                    switch(line[i]) 
                    {
                        case "a":
                            a += 1;
                            break;
                        case "b":
                            b += 1;
                            break;
                        case "c":
                            c += 1;
                            break;
                        case "d":
                            d += 1;
                            break;
                        case "e":
                            e += 1;
                            break;
                        case "f":
                            f += 1;
                            break;
                        case "g":
                            g += 1;
                            break;
                        case "h":
                            h += 1;
                            break;
                        case "i":
                            i += 1;
                            break;
                        case "j":
                            j += 1;
                            break;
                        case "k":
                            k += 1;
                            break;
                        case "l":
                            l += 1;
                            break;
                        case "m":
                            m += 1;
                            break;
                        case "n":
                            n += 1;                               
                            break;
                        case "o":
                            o += 1;
                            break;
                        case "p":
                            p += 1;
                            break;
                        case "q":
                            q += 1;
                            break;
                        case "r":
                            r += 1;
                            break;
                        case "s":
                            s += 1;
                            break;
                        case "t":
                            t += 1;
                            break;
                        case "u":
                            u += 1;
                            break;
                        case "v":
                            v += 1;
                            break;
                        case "w":
                            w += 1;
                            break;
                        case "x":
                            x += 1;
                            break;
                        case "y":
                            y += 1;
                            break;
                        case "z":
                            z += 1;
                            break;
                        default: break;
