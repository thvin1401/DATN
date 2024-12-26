PGDMP                          |         	   DATN_QLBH    15.3    15.3 -    M           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            N           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            O           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            P           1262    347430 	   DATN_QLBH    DATABASE     �   CREATE DATABASE "DATN_QLBH" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE "DATN_QLBH";
                postgres    false            �            1259    347431    accessingrole    TABLE     �   CREATE TABLE public.accessingrole (
    id uuid NOT NULL,
    accounttype integer,
    functionid integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
 !   DROP TABLE public.accessingrole;
       public         heap    postgres    false            �            1259    347434    account    TABLE       CREATE TABLE public.account (
    username character varying(255) NOT NULL,
    password character varying(255),
    userinfoid uuid,
    isenabled boolean,
    accounttype integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.account;
       public         heap    postgres    false            �            1259    347439    bill    TABLE     S  CREATE TABLE public.bill (
    receiptnumber integer NOT NULL,
    amount double precision,
    discount double precision,
    payamount double precision,
    isdeleted boolean,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone,
    userinfoid uuid,
    billtype integer,
    ispaid boolean
);
    DROP TABLE public.bill;
       public         heap    postgres    false            �            1259    347442 
   categories    TABLE     �   CREATE TABLE public.categories (
    id uuid NOT NULL,
    name character varying(255),
    isdeleted boolean,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.categories;
       public         heap    postgres    false            �            1259    347445    currencyexchange    TABLE     �   CREATE TABLE public.currencyexchange (
    name character varying NOT NULL,
    exchangerate double precision,
    type integer
);
 $   DROP TABLE public.currencyexchange;
       public         heap    postgres    false            �            1259    347450    debtmanager    TABLE     �  CREATE TABLE public.debtmanager (
    id uuid NOT NULL,
    receiptnumber integer,
    interest double precision,
    circle integer,
    status integer,
    processeddatetime timestamp without time zone,
    paiddatetime timestamp without time zone,
    type integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone,
    paidbeforetime timestamp without time zone
);
    DROP TABLE public.debtmanager;
       public         heap    postgres    false            �            1259    347453    note    TABLE        CREATE TABLE public.note (
    id uuid NOT NULL,
    message text,
    isdone boolean,
    isdeleted boolean,
    reminddatetime timestamp without time zone,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.note;
       public         heap    postgres    false            �            1259    347458    payment    TABLE     �   CREATE TABLE public.payment (
    id uuid NOT NULL,
    receiptnumber integer,
    amount double precision,
    userinfoid uuid,
    paymentmethod integer,
    paydatetime timestamp without time zone,
    createdatetime timestamp without time zone
);
    DROP TABLE public.payment;
       public         heap    postgres    false            �            1259    347461    productmanager    TABLE     !  CREATE TABLE public.productmanager (
    id uuid NOT NULL,
    receiptnumber integer,
    productid uuid,
    quantity integer,
    unitprice double precision,
    discount double precision,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
 "   DROP TABLE public.productmanager;
       public         heap    postgres    false            �            1259    347464    products    TABLE     �  CREATE TABLE public.products (
    id uuid NOT NULL,
    name character varying(255),
    quantity integer,
    unitprice double precision,
    providerid uuid,
    isdeleted boolean,
    categoryid uuid,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone,
    importdatetime timestamp without time zone,
    weight integer,
    importprice double precision
);
    DROP TABLE public.products;
       public         heap    postgres    false            �            1259    347467    ranking    TABLE       CREATE TABLE public.ranking (
    id uuid NOT NULL,
    name character varying(255),
    isactive boolean,
    discount double precision,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone,
    achivepoint integer
);
    DROP TABLE public.ranking;
       public         heap    postgres    false            �            1259    347470    receipt_number    SEQUENCE     �   CREATE SEQUENCE public.receipt_number
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 1000000
    CACHE 1
    CYCLE;
 %   DROP SEQUENCE public.receipt_number;
       public          postgres    false            �            1259    347471    systemproperty    TABLE     �   CREATE TABLE public.systemproperty (
    name character varying(255) NOT NULL,
    value character varying(255),
    description character varying(255),
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
 "   DROP TABLE public.systemproperty;
       public         heap    postgres    false            �            1259    347476    userinfo    TABLE     �  CREATE TABLE public.userinfo (
    id uuid NOT NULL,
    name character varying(255),
    address character varying(255),
    phone character varying(50),
    email character varying(100),
    rankid uuid,
    isactive boolean,
    point integer,
    type integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone,
    birthday timestamp without time zone
);
    DROP TABLE public.userinfo;
       public         heap    postgres    false            =          0    347431    accessingrole 
   TABLE DATA           d   COPY public.accessingrole (id, accounttype, functionid, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    214   �9       >          0    347434    account 
   TABLE DATA           y   COPY public.account (username, password, userinfoid, isenabled, accounttype, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    215   �9       ?          0    347439    bill 
   TABLE DATA           �   COPY public.bill (receiptnumber, amount, discount, payamount, isdeleted, createdatetime, updatedatetime, userinfoid, billtype, ispaid) FROM stdin;
    public          postgres    false    216   4:       @          0    347442 
   categories 
   TABLE DATA           Y   COPY public.categories (id, name, isdeleted, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    217   �;       A          0    347445    currencyexchange 
   TABLE DATA           D   COPY public.currencyexchange (name, exchangerate, type) FROM stdin;
    public          postgres    false    218   �;       B          0    347450    debtmanager 
   TABLE DATA           �   COPY public.debtmanager (id, receiptnumber, interest, circle, status, processeddatetime, paiddatetime, type, createdatetime, updatedatetime, paidbeforetime) FROM stdin;
    public          postgres    false    219   A<       C          0    347453    note 
   TABLE DATA           n   COPY public.note (id, message, isdone, isdeleted, reminddatetime, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    220   f=       D          0    347458    payment 
   TABLE DATA           t   COPY public.payment (id, receiptnumber, amount, userinfoid, paymentmethod, paydatetime, createdatetime) FROM stdin;
    public          postgres    false    221    >       E          0    347461    productmanager 
   TABLE DATA           �   COPY public.productmanager (id, receiptnumber, productid, quantity, unitprice, discount, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    222   K@       F          0    347464    products 
   TABLE DATA           �   COPY public.products (id, name, quantity, unitprice, providerid, isdeleted, categoryid, createdatetime, updatedatetime, importdatetime, weight, importprice) FROM stdin;
    public          postgres    false    223   �C       G          0    347467    ranking 
   TABLE DATA           l   COPY public.ranking (id, name, isactive, discount, createdatetime, updatedatetime, achivepoint) FROM stdin;
    public          postgres    false    224   �F       I          0    347471    systemproperty 
   TABLE DATA           b   COPY public.systemproperty (name, value, description, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    226   �G       J          0    347476    userinfo 
   TABLE DATA           �   COPY public.userinfo (id, name, address, phone, email, rankid, isactive, point, type, createdatetime, updatedatetime, birthday) FROM stdin;
    public          postgres    false    227   mH       Q           0    0    receipt_number    SEQUENCE SET     =   SELECT pg_catalog.setval('public.receipt_number', 62, true);
          public          postgres    false    225            �           2606    347482     accessingrole accessingrole_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.accessingrole
    ADD CONSTRAINT accessingrole_pkey PRIMARY KEY (id);
 J   ALTER TABLE ONLY public.accessingrole DROP CONSTRAINT accessingrole_pkey;
       public            postgres    false    214            �           2606    347484    account account_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_pkey PRIMARY KEY (username);
 >   ALTER TABLE ONLY public.account DROP CONSTRAINT account_pkey;
       public            postgres    false    215            �           2606    347486    bill bill_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.bill
    ADD CONSTRAINT bill_pkey PRIMARY KEY (receiptnumber);
 8   ALTER TABLE ONLY public.bill DROP CONSTRAINT bill_pkey;
       public            postgres    false    216            �           2606    347488    categories categories_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.categories
    ADD CONSTRAINT categories_pkey PRIMARY KEY (id);
 D   ALTER TABLE ONLY public.categories DROP CONSTRAINT categories_pkey;
       public            postgres    false    217            �           2606    347490 "   currencyexchange currencytype_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.currencyexchange
    ADD CONSTRAINT currencytype_pkey PRIMARY KEY (name);
 L   ALTER TABLE ONLY public.currencyexchange DROP CONSTRAINT currencytype_pkey;
       public            postgres    false    218            �           2606    347492    debtmanager debtmanager_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.debtmanager
    ADD CONSTRAINT debtmanager_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.debtmanager DROP CONSTRAINT debtmanager_pkey;
       public            postgres    false    219            �           2606    347494    note note_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.note
    ADD CONSTRAINT note_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.note DROP CONSTRAINT note_pkey;
       public            postgres    false    220            �           2606    347496    payment payment_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.payment DROP CONSTRAINT payment_pkey;
       public            postgres    false    221            �           2606    347498 "   productmanager productmanager_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.productmanager
    ADD CONSTRAINT productmanager_pkey PRIMARY KEY (id);
 L   ALTER TABLE ONLY public.productmanager DROP CONSTRAINT productmanager_pkey;
       public            postgres    false    222            �           2606    347500    products products_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.products DROP CONSTRAINT products_pkey;
       public            postgres    false    223            �           2606    347502    ranking ranking_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.ranking
    ADD CONSTRAINT ranking_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.ranking DROP CONSTRAINT ranking_pkey;
       public            postgres    false    224            �           2606    347504 !   systemproperty systempropery_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.systemproperty
    ADD CONSTRAINT systempropery_pkey PRIMARY KEY (name);
 K   ALTER TABLE ONLY public.systemproperty DROP CONSTRAINT systempropery_pkey;
       public            postgres    false    226            �           2606    347506    userinfo userinfo_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.userinfo
    ADD CONSTRAINT userinfo_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.userinfo DROP CONSTRAINT userinfo_pkey;
       public            postgres    false    227            =      x������ � �      >   w   x�]�1�0E��\��6&�{�DvT���*���{�/�Sk����6}�@��}�([�"$���v!Z�N�p�~��m�۷V��$���:����|o������>9x\��)Y      ?   \  x���Mn� ���� �ml�s�nB'��UO�L�	�(b���d�'� 
v\�;b��I�
i�0���F�����g��k$�k��m�j�?�%�<�#��!ƀp��M�r�=v�ܘ���l���S�Ay�	8F������b1w�i��s;"���'����J+�V�*�E�)��%���f(�H�$=協
�Л���\T�czO9 ��ɞ��g�z����)=X�DNҩn�\��N�75�����*�k�r	��vo>�q.{��m�vo2�F���%�=����+�ۛ'��)���IX0��7�r��w���;i�M��8K�yӉPr)Z�IO�J"�y�M�>ޗe���N)      @   N   x�mȻ�  �Z�����i��;��Y �|Z/-��`�����Ꝗ���<0q�����4��"�	 �#      A   3   x�s�4�050�4��.�44 ��B�]8��@�F\a~.���\1z\\\ נM      B     x�u��mD!E�PEpd�+"̆o�%�7IF�bw��G��H�0U0V�fP�D�A
�����9F �o���=>V�L	�_�c昲d��Z�2ƭPj�<����^�.ԭ�38��
7�ז�'���K�e�SdNQ��i8)p<(����*p�uΜ�����R0�lrw*�����M7�������V��\J �a)DR0!�2Jn�:Փ�)�É�V��[��:H	*�f��d�yS]�.�|ǟ��^
��?޽���=�      C   �   x�mα�0@�:�B���q2%Ml'���i�;�`.+P�2�d\rR�
}�d�4!�T��Mߢ�}�Y=���H.��
q�'��+!-�X�yH�",%(�(j$���ר�2Q;ֆj���F�:���B+-)��t�r�M.��Lp�����;�5���y׳�?�j��a'�� u�?      D     x��TK�!\ӧ���}�l0��!~��2=��^�RSE�e���+D`��%����ȍ�{-bkm5W���!8k4�<�	ax�5�(�P%$���M�F~�.D�8��=Ig��$�]7"������c�d��ӏ�,!�<��١չɓ>�vy�!C�������H:��P/���X���#�H#�y���}~��w}Į&�v�<���08�0{mGO����������K���ּ ��-��г͋CX,��}���(O��vt��Ai����mP�97i�i��l#}��vW}�.v�됂Z��s=iG6�#ܖ�e/���qˀ=a��B�mY� 6$���C�6��m�߉{ϸ��O�����i���˱u%����X7��������j�®���YΨ+��!����ͫYQ+oF���%�q{�1�.�O�0g�2lF�i��o'o�7=bQ�|�f�������I<TJ��O���=aW�p��-�[�6'�Kj:�櫛�.�3��6��>��O����u]���u�      E   c  x��VK�#7\w�"` J�G>K6�(���&���ixcZ&�dU�[�hi:�.s�UC�|��R��W��[�B�C�L�>*�j�u��P.��.�\媥v�
��������C�s�K[ЧhU��7������2��(;6t�m@��Hp�y��U:�|=�k6|��!��Ą5$�
�����dM���ˎQ�9�.-`��U9H�h喓�D�y�����n�ŝrd� :�h���:i�A�9ʤi�m�9��G�9w;�X������-
r�@msr�ؐ	��;FD~��B���S73t�>7�e��
�:f"���.�}gÉ��F�W�\u/�0����C��m]T?磾
=��nF��2��A���y̬��� Cw%M���'�r��6
��f�3�!�#x�=L-J�`�J�"�SÝ; �خm,�ƻ����P�btM% }�÷ �vU,�8;�jg)���y*��#�k�<�i9�i�JH<�qY�1]�,oT~�ݮ���͎3����v����: >��[�j�=	�!�4�!^�q*Y!w�I����L��E��j)#]�8c?~@wR�s ������ ���ڳ+a*�?���j�)v�7�����{2t�|P\��g��/a��#�X�`�QV��g�鴸d��Z!���z+3�
4�nIUU[������qd�o���U���+v�!9;���;�&�O��k�m�ǐ�~�n�w����򪏱;���� ʹ_՜FqMi�]�$Ґ�ş�	Y-��O��A�]�&�̌9�3wzL���� H6=���6�*�/1ұy�\��*�ڔ�ׇL�W��x�����%�����(y�']"� �������}���&�      F     x���Kn�F�לS��tw=���QlȆّC�l�� � F �B6�f��^:�MR�F����\�"�������-S0�
�LFr�&5p(\�Oǫ�������x�������p��x#��j=��Z�z�3@(�P
#�J ��c�9C���u
P�MI4�#�[c{�R�F��h�7�Gg'���Ś���a�u��*J��Y�ܻS��FxN���5��"�����x�I��͸������g����2ݍ�[�'�ŧm�����4`8��C-�	��n���ZD�h����:��u�6L�\{����`����JH�C$�X�,Ysk�X��ˢ.��˹���;N辄;N�!�U�0\�V��Ģe����Ԕ��o��>��y�����G��g=���0����BMQ5�����/xk�k3;|�r������{;����v.�}w?��qA�3�� t����c�%Kr�SlF$5�K�R�2�v�������6���Ct�����% &W����A��J5�c&��W��	�b��Nq�TD��*��HԽzՔ�5�+D5��(�����4�r�Ԗ��h/�m&�'knra�Kp�R��+ع�B%iM{�j�#�R:��ٜ�
�\�߽^�0���W�\Z5ޏ�#
�&-�Q&
�q:/Q��'�w&� t.�\t
%�+ͺ�cY2�9��T���R�I���<j�:Y�z��!)���w��^�O�Ԩ��]c�0�gxҲ��D'���������
�V}�I��x�f�Z�i>0�      G   �   x�u�1� ��N�8���!����&�T����iӑ����=RI�BG) �`036kh�2�#���X8��Y���{�=럆�ho��4y� Hx���i-e�^.��:M�<mt��`��l��Cl� gEq�*���O���k���a=�      I   �   x���Ak�0��ί��#��z�B��mo�[�$g��~q3X��=}5�Ƙ�!�ڼ�R�v��%a�����)	���-�,�_��g����}늮-��x6����QB��"Сa��v���Էҷ��O�#$<��`���Z,-�J�2�����/��;$P-�2W�=3�sӁ������ڑ�=��YC��ן쵮����      J     x��S��A��_�?Ч����X��8!�y�xW»�d#��� ��R������[@`��MP�v�T�v6��-��%PK��1���k[W�8��n>�|�|^7����۫�lڼ���*�2X���􃢇�e�_��q)�6]��z�
�k���IJD��+!�C�
m#���&H��6s%�v��Wy�E��������I����Ӯ���?�r��7}�?��Qe��H��|�w�dT�֓����9���e��Mt�.8��i���l�I��Q�x�h��Lq�"�-�Iɡ��/9(�\��q ���ݗ��â9鍊��8��is=,8��<IEV�׫�D*G:K��ĉ̅�c�1�H٨��G(�L�m&�^&mI�-�r&�z.�%��Q���a�N��?0��r1a��E^�����X�����g)��[J�&k�Ů�m�yQ�\����X��$���i���~e[����p�D+4ȶ�n��8�8G(	jO�˓�l��v:     