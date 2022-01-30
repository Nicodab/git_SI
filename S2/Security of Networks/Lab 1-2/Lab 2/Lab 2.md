# Lab 2

# Part 1: Verify Connectivity and Explore the ASA

Step 1 :

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled.png)

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%201.png)

Step 2:

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%202.png)

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%203.png)

Step 3:

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%204.png)

# Part 2: Configure ASA Settings and Interfaces Security Using the CLI

Step 1:

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%205.png)

Step 2:

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%206.png)

Step 3:

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%207.png)

Step 4:

a) and b)

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%208.png)

c) 

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%209.png)

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2010.png)

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2011.png)

Step 5:

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2012.png)

# Part 3: Configure Routing, Address Translation, and Inspection Policy Usinf the CLI

Step 1:

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2013.png)

![ping from ASA to R1’s interface S0/0/0 ](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2014.png)

ping from ASA to R1’s interface S0/0/0 

Step 2:

a)

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2015.png)

b)

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2016.png)

![show run command on ASA](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2017.png)

show run command on ASA

c)

![Ping from PC-B to R1’s interface G0/0](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2018.png)

Ping from PC-B to R1’s interface G0/0

Step 3:

a)

![Creation of a class-map and ICMP inspection](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2019.png)

Creation of a class-map and ICMP inspection

b)

![Ping from PC-B to R1’s interface G0/0](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2020.png)

Ping from PC-B to R1’s interface G0/0

# Part 4: Configure DHCP, AAA, and SSH

Step 1:

a) b) c)

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2021.png)

d)

![Change PC-B from static to DHCP addressing  ](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2022.png)

Change PC-B from static to DHCP addressing  

After enabling the daemon DHCP within the ASA to listen for DHCP client requests on the interface (inside), PC-B has seen his IPv4 address changed from 192.168.1.3 to 192.168.1.5  

Step 2:

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2023.png)

Step 3:

a) b)

![RSA key pair creation and ASA configuration for ssh connections](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2024.png)

RSA key pair creation and ASA configuration for ssh connections

c)

![SSH connection from PC-C to ASA (from outside)](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2025.png)

SSH connection from PC-C to ASA (from outside)

d)

![SSH connection from PC-C to ASA (from inside)](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2026.png)

SSH connection from PC-C to ASA (from inside)

We can see that both of the ssh connections from inside and outside work perfectly well.

# Part 5: Configure a DMZ, Static NAT, and ACLs

Step 1:

a)

![Configuration of VLAN 3](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2027.png)

Configuration of VLAN 3

b)

![Assigning + enabling ASA’s interface E/0 to VLAN3 ](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2028.png)

Assigning + enabling ASA’s interface E/0 to VLAN3 

c)

1)

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2029.png)

2)

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2030.png)

 

3)

![Untitled](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2031.png)

Every configuration seems to correct.

Step 2:

![Static NAT translation from DMZ address to OUTSIDE address](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2032.png)

Static NAT translation from DMZ address to OUTSIDE address

Step 3:

![ACL configuration for DMZ access (from outside)](Lab%202%208f0692b5a95c435995ff9cbb0c7d7dc9/Untitled%2033.png)

ACL configuration for DMZ access (from outside)

Step 4:

Not required.

Step 5:

Completed.