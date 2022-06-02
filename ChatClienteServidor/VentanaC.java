package clases;

import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;
import java.util.LinkedList;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.UIManager;
import javax.swing.UIManager;


//Clase que maneja la interfaz gráfica del cliente
public class VentanaC extends javax.swing.JFrame {
    
    public String mensaje;
        
    public VentanaC() {
        initComponents();
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        String ip_puerto_nombre[]=getIP_Puerto_Nombre();
        String ip=ip_puerto_nombre[0];
        String puerto=ip_puerto_nombre[1];
        String nombre=ip_puerto_nombre[2];
        cliente=new Cliente(this, ip, Integer.valueOf(puerto), nombre);
        
    }
    @SuppressWarnings("unchecked")
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        txtHistorial = new javax.swing.JTextArea();
        txtMensaje = new javax.swing.JTextField();
        btnEnviar = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowClosed(java.awt.event.WindowEvent evt) {
                formWindowClosed(evt);
            }
            public void windowClosing(java.awt.event.WindowEvent evt) {
                formWindowClosing(evt);
            }
        });

        txtHistorial.setEditable(false);
        //20
        txtHistorial.setColumns(30);
        txtHistorial.setFont(new java.awt.Font("Bahnschrift Light", 0, 12)); // NOI18N
        txtHistorial.setForeground(new java.awt.Color(0, 0, 0));
        txtHistorial.setLineWrap(true);
        txtHistorial.setRows(5);
        txtHistorial.setDoubleBuffered(true);
        txtHistorial.setDragEnabled(true);
        txtHistorial.setBackground(Color.DARK_GRAY);
        jScrollPane1.setViewportView(txtHistorial);

        txtMensaje.setFont(new java.awt.Font("Bahnschrift Light", 0, 17)); // NOI18N
        txtMensaje.setForeground(new java.awt.Color(0, 0, 0));


        btnEnviar.setFont(new java.awt.Font("Bahnschrift Light", 0, 13)); // NOI18N
        btnEnviar.setText("Enviar mensaje");
        btnEnviar.setForeground(Color.WHITE);
        btnEnviar.setBackground(Color.BLACK);
        btnEnviar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEnviarActionPerformed(evt);
            }
        });

        jLabel1.setText("CHAT GRUPAL");
        jLabel1.setFont(new Font ("Bahnschrift Light", Font.BOLD+Font.ITALIC, 20));
        jLabel1.setForeground(Color.BLACK);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);

        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel1)
                        )
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(txtMensaje)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnEnviar))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 150, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        
                        
                .addContainerGap())))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jLabel1)
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 500, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(txtMensaje)
                    .addComponent(btnEnviar, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addContainerGap(12, Short.MAX_VALUE))
        );

        pack();
    }

    private void formWindowClosed(java.awt.event.WindowEvent evt) {
    }

    private void formWindowClosing(java.awt.event.WindowEvent evt) {
        cliente.confirmarDesconexion();
    }

    private void btnEnviarActionPerformed(java.awt.event.ActionEvent evt) {
        if(txtMensaje.getText().equals("1")|| txtMensaje.getText().equals("0")){
            txtHistorial.append("Yo: \n¿Cual es el factoria de " + txtMensaje.getText() + "?\n");
            txtHistorial.append("El factorial es 1\n");
            txtMensaje.setText("");
        }else{
            mensaje=txtMensaje.getText();
            cliente.enviarMensaje(mensaje);
            txtHistorial.append("Yo: \n¿Cual es el factorial de " + mensaje + "?\n");
            txtMensaje.setText("");
        }
    }

    

    private void txtMensajeActionPerformed(java.awt.event.ActionEvent evt){

    }

    private void txtMensajeKeyTyped(java.awt.event.KeyEvent evt) {
        char validar = evt.getKeyChar();

        if (txtMensaje.getText().length()>=5){
            evt.consume();
        }else {
            if(!Character.isDigit(validar));
        }
    }





    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {

        Color color = new Color(152, 12, 52);
        UIManager.put("nimbusBase", color.CYAN);
        UIManager.put("control", color.GREEN);

        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(VentanaC.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(VentanaC.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(VentanaC.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(VentanaC.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new VentanaC().setVisible(true);
            }
        });
    }
    private javax.swing.JButton btnEnviar;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextArea txtHistorial;
    private javax.swing.JTextField txtMensaje;
    
    private final String DEFAULT_PORT="1024";
    
    private final String DEFAULT_IP="127.0.0.1";
    
    private final Cliente cliente;
    /**
     * @param contacto 
     */
    void addContacto(String contacto) {

        
    }
    void addMensaje(String emisor, String mensaje) {

        txtHistorial.append(emisor + " \n" + mensaje+"\n");
    }
    /**
     * @param identificador 
     */
    void sesionIniciada(String identificador) {
        this.setTitle("En Línea "+identificador);
    }
    /**
     * @return 
     */
    private String[] getIP_Puerto_Nombre() {
        String s[]=new String[3];
        s[0]=DEFAULT_IP;
        s[1]=DEFAULT_PORT;
        JTextField ip = new JTextField(15);
        ip.setFont(new Font ("Bahnschrift Light", Font.ITALIC, 12));
        ip.setBackground(Color.BLACK);
        ip.setForeground(Color.white);

        JTextField puerto = new JTextField(15);
        puerto.setFont(new Font ("Bahnschrift Light", Font.ITALIC, 12));
        puerto.setBackground(Color.BLACK);
        puerto.setForeground(Color.white);

        JTextField usuario = new JTextField(15);
        usuario.setFont(new Font ("Bahnschrift Light", Font.ITALIC, 12));
        usuario.setBackground(Color.BLACK);
        usuario.setForeground(Color.white);

        ip.setText(DEFAULT_IP);
        puerto.setText(DEFAULT_PORT);
        usuario.setText("");
        JPanel myPanel = new JPanel();
        myPanel.setLayout(new GridLayout(3, 2));
        myPanel.add(new JLabel("IP del Servidor: "));
        myPanel.add(ip);
        myPanel.add(new JLabel("Puerto: "));
        myPanel.add(puerto);
        myPanel.add(new JLabel("Nombre de usuario: "));
        myPanel.add(usuario);
        int result = JOptionPane.showConfirmDialog(null, myPanel, 
                 "Configuraciones de la comunicación", JOptionPane.OK_CANCEL_OPTION, JOptionPane.PLAIN_MESSAGE);
                 
        if (result == JOptionPane.OK_OPTION) {
                s[0]=ip.getText();
                s[1]=puerto.getText();
                s[2]=usuario.getText();
        }else{
            System.exit(0);
        }
        return s;
    }
    void eliminarContacto(String identificador) {
        
        System.out.println("Se elimino el usuario");
        
        return;
    }
}