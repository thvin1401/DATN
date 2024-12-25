PGDMP         -                |         	   DATN_QLBH    15.3    15.3 -    M           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
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
       public         heap    postgres    false            �            1259    347464    products    TABLE     s  CREATE TABLE public.products (
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
    weight integer
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
    public          postgres    false    214   a9       >          0    347434    account 
   TABLE DATA           y   COPY public.account (username, password, userinfoid, isenabled, accounttype, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    215   ~9       ?          0    347439    bill 
   TABLE DATA           �   COPY public.bill (receiptnumber, amount, discount, payamount, isdeleted, createdatetime, updatedatetime, userinfoid, billtype, ispaid) FROM stdin;
    public          postgres    false    216   �:       @          0    347442 
   categories 
   TABLE DATA           Y   COPY public.categories (id, name, isdeleted, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    217   f<       A          0    347445    currencyexchange 
   TABLE DATA           D   COPY public.currencyexchange (name, exchangerate, type) FROM stdin;
    public          postgres    false    218   �<       B          0    347450    debtmanager 
   TABLE DATA           �   COPY public.debtmanager (id, receiptnumber, interest, circle, status, processeddatetime, paiddatetime, type, createdatetime, updatedatetime, paidbeforetime) FROM stdin;
    public          postgres    false    219   =       C          0    347453    note 
   TABLE DATA           n   COPY public.note (id, message, isdone, isdeleted, reminddatetime, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    220   �=       D          0    347458    payment 
   TABLE DATA           t   COPY public.payment (id, receiptnumber, amount, userinfoid, paymentmethod, paydatetime, createdatetime) FROM stdin;
    public          postgres    false    221   F?       E          0    347461    productmanager 
   TABLE DATA           �   COPY public.productmanager (id, receiptnumber, productid, quantity, unitprice, discount, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    222   �A       F          0    347464    products 
   TABLE DATA           �   COPY public.products (id, name, quantity, unitprice, providerid, isdeleted, categoryid, createdatetime, updatedatetime, importdatetime, weight) FROM stdin;
    public          postgres    false    223   �E       G          0    347467    ranking 
   TABLE DATA           l   COPY public.ranking (id, name, isactive, discount, createdatetime, updatedatetime, achivepoint) FROM stdin;
    public          postgres    false    224   �F       I          0    347471    systemproperty 
   TABLE DATA           b   COPY public.systemproperty (name, value, description, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    226   9G       J          0    347476    userinfo 
   TABLE DATA           �   COPY public.userinfo (id, name, address, phone, email, rankid, isactive, point, type, createdatetime, updatedatetime, birthday) FROM stdin;
    public          postgres    false    227   H       Q           0    0    receipt_number    SEQUENCE SET     =   SELECT pg_catalog.setval('public.receipt_number', 45, true);
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
       public            postgres    false    227            =      x������ � �      >   2  x��ұn!���)2use��)]:�	� �K�w����n��ޒJX���d����|�N��0���a�N������ۄ�V�{y�
��$e��Z�lc�*��!��g�n�1Ki��
d�XCl5�����������_��F����L!\�A�>A7V[RP�(m�������.B*9@b�qI=
k�׆h
���x����[���A"V�[.ف����9�5[���鯊͉%P�	z�������jL*b�C���R)��<��;r�i��k0�B��U�fm���!��<��ѕ��      ?   �  x���M�� ���}��s�>Ao����5$����A�L��z��'����8���#O�@�A��rХ�J�[�����!`�WH�B8��h��s���
�3�R�Rp��J"����i��6�ĩ �AH��nI�-9v�7N�~x�	�ĵ0���ߠ`U���`��:ܽ翄��h�Q�wA1�_j��R<������"X*-y2�$�����>,S{�M�\�Ԥwc�1������94o\PcD���a<{��2�R�LrJ�}W�̞3�R�����ϸ}W+.�K�>8O9`�oԜ�_���J_���]����<E���f��v1�c�����U>f�Q����}kp�XA<��V��Va+qߨ�_�G)�2�.%d'}�ڶ��a�      @   T   x�KJ�H43�4׵��4�516�еH5)�&�F&�iIɜΉ%���E�
��i�FF&�����
��V&&V��ĸb���� i�j      A   3   x�s�4�050�4��.�44 ��B�]8��@�F\a~.���\1z\\\ נM      B   �   x�}�K�� Eǰ�n�O�$�x+����%��R�*U�s����̪\���V�JЙ����!�Á	 ����p���$�\0�$���W�Vd�(.��!��F�fm�X~W�5��,�.�Q�ɢ�ޭ������������ι�뜭{�w�gB�U��A��1�Eϒ�Z�=�,V��2xO	���V��>ߩ�6���]�C\1����_����k�      C   ?  x�u�=n�0Fg�� ��$Rs瞠�~��ׯ�"nb���|OT�RG��y�H2� ��f;z���s�䯏��1?Bb�����i"�crg�c�'6��y8h�*�Π�\�҆�16�}�ݧO�?꘍�"�`Wd��lf���ʦ��򨋷J����'�F}(Y�u�� �E�[��lU�hӹ�:�;���r�L�����8è!x� ��\�-o���{��]-'�D�q��9{�Lq�Y
D���;zEW�T�Q7��vD��y��O|Wf�΂����i$/y�s����ݎ�6!�0�3�����1��n      D   V  x���[��0E��U�QzY��~,?���
fUt�G�M��W��ɬXa�e�%��
�]9|L�~H9���9�$j�:Hk��]��W��U�=ہ#+�'��R~�ε��v�Q@ew���5B\)�:�f�W8�*R{G��걠�a�B���4~�]JOڙg�E�a^B�)��	��)u�.��ë��5/,�;y;��(�[(��K�jF�W|��xQ~�I;Y[� �f�x��j��P��h[�!~�(�;����I;;��N����Ͼz+�g�jF��v�5�E<����Ӫ@ɧ�6aMuS9o����~�N\B���s�0�QLH-�������7�H�?e�#�md
�a�,��)�Go�ٗ�͖Y4Ñ��8��6y���=](�Гv��6����,t�I�>2t�ܾ8�O��A��9�.5��ɋ]&�,�B�Lf�%w������7�_:?�������f����F���0|��{�_���g�DN��	{h�}��^��S�xG�X�����}%�U�/�ȘRV�R�}ˮ������o��vF-���:t���y`�<�[	N~�����w;����\����_>�����k�      E   �  x��W[r#7��9�/� �����!=�M�g֎$�T����F7R��5q��t�J5wN}}�2&�1	�͔�Ԥm{j�5�!�����f΄��!����?�T�w�s�i�/M^e%���li�쬔K�BP��Eʾj�=%�j%���l�T� �Ku{
 �E���҆��ZS�ka�3v|�M
�A���v��-$qk;��Zk�ʃ}M*��B�_����

zL�aq˜��h9�ߧ��w��G�����=uO�f��*˅�Rޓ��I>�i�30�� ��O�h-�(��-��r�����~��@/�Q��Β��ܽ+ �)�E0�����/ o��+ �-�֜��}��޹�E�7�"xӈ
�=��j�W]5 �f��] `�j�;�e[���*��ʇ�C����Yjt*�&l&X�`D���h�!��H�� j��hN�i�J
F����lļ ������VXGjW�vC����ʁ�X�e� ��������x�]�lð.��P��)<H.2GE# ??�_X����٩'�u|
��!����,�#��73{H��NU�$��Ё`�n��pD3�I���z:�`�lI�_�̸����愬Er���o[a��vW;izz�����ń`JкC���z�x�����C��;�C��������hG���pǟQ��2Oj�[C'f�1������<�}9+?7�t���j���eaFS4;��{#�c���yС�/>7���0����^g�⁜vą����`T���&p���Y'd�LkA�0%���j�<�}��1 �]P7z�
���B+�5/O^��u���u�����p�W8$�@�8 �ސ��h<��Z���8�T�Ģw��ȥ)�o��Ykip��H�~�Q�6]8�� �y�.	9�W|Jj�]m
E)f
"�[��M�����Qߞ���y	]�����NFt�օ�e
���_�y��`(�      F   �   x���=j1��>�\@A�,�"H��6��g�l��[�ć�^
m�1u
���L�_��g~��K#�&i���o���,�[��e��J�v:G�ܠ5'P�-�%��������A�Q:�}�@v u���'�2bY m)���sr�c��@PrND$/UHW�
.��Ӟ�jT��X4н�T8E�QT�>���q���Wv��"�K*��-���R��      G   �   x�u�1� ��N�8���!����&�T����iӑ����=RI�BG) �`036kh�2�#���X8��Y���{�=럆�ho��4y� Hx���i-e�^.��:M�<mt��`��l��Cl� gEq�*���O���k���a=�      I   �   x���Ak�0��ί��#��z�B��mo�[�$g��~q3X��=}5�Ƙ�!�ڼ�R�v��%a�����)	���-�,�_��g����}늮-��x6����QB��"Сa��v���Էҷ��O�#$<��`���Z,-�J�2�����/��;$P-�2W�=3�sӁ������ڑ�=��YC��ן쵮����      J   �  x���ϊ�H���O����RU�r���{�����6L���_y'$>�v:a�#���W�>q+�p#2tBα 'I8|+����PN�G��:�Jm��O�����޻���4*L�
��Se�	�Jɂ�]fG����qA|��������x��ɧ��Z��@�W�A1�TcՁ�����˱���H�e�����ױ��;P�9x@�Ocu���~���nF}\֯'�#����jm�*�t��n�k��4�"ءPM@C��>E��ލ����xp�ey����� �矟�\;hO�4�,̨Z��)���MB���I��4���@�T�ǐ�"a,�̬H$���i�h�K)f(�Q�o�j�"�LҀ�r�)h6 ,���s+�T5� s�&��X@�6����f�JW��j�V�Y�},�5ACs�!��0��lѥӤ� OO�f_(�Hi��e%�S�m���
\J�"-��ƞ/��$zcW�4�w��ٸ�'Ӵ��)ao�����t�������r���rsn��Mg�#���ݗ�do���H3�gI�珐 �,�Q��Rl��3H����f5{ g�����q��޶=vȚF�U�m,���K�ƾ��:ul�AY_H��a�x�"��>֭��:�����>���ݘ�����z��|�+���U���*�OU��ʸS9u"��L^�L�2��K6n�M-��m��Rawcz���^�ߒ���a�pY�_�e��_     